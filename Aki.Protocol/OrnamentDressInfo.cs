using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAF RID: 2991
	public sealed class OrnamentDressInfo : IMessage<OrnamentDressInfo>, IMessage, IEquatable<OrnamentDressInfo>, IDeepCloneable<OrnamentDressInfo>, IBufferMessage
	{
		// Token: 0x06010380 RID: 66432 RVA: 0x0025E340 File Offset: 0x0025C540
		[NullableContext(1)]
		public static OrnamentDressInfo Create()
		{
			return new OrnamentDressInfo();
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x06010381 RID: 66433 RVA: 0x0025E347 File Offset: 0x0025C547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OrnamentDressInfo> Parser
		{
			get
			{
				return OrnamentDressInfo._parser;
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x06010382 RID: 66434 RVA: 0x0025E34E File Offset: 0x0025C54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x06010383 RID: 66435 RVA: 0x0025E351 File Offset: 0x0025C551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentDressInfo.Descriptor;
			}
		}

		// Token: 0x06010384 RID: 66436 RVA: 0x0025E358 File Offset: 0x0025C558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo()
		{
		}

		// Token: 0x06010385 RID: 66437 RVA: 0x0025E36B File Offset: 0x0025C56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo(OrnamentDressInfo other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.dressOrnamentIds_ = other.dressOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010386 RID: 66438 RVA: 0x0025E3A1 File Offset: 0x0025C5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo Clone()
		{
			return new OrnamentDressInfo(this);
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x06010387 RID: 66439 RVA: 0x0025E3A9 File Offset: 0x0025C5A9
		// (set) Token: 0x06010388 RID: 66440 RVA: 0x0025E3B1 File Offset: 0x0025C5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x06010389 RID: 66441 RVA: 0x0025E3BA File Offset: 0x0025C5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressOrnamentIds
		{
			get
			{
				return this.dressOrnamentIds_;
			}
		}

		// Token: 0x0601038A RID: 66442 RVA: 0x0025E3C2 File Offset: 0x0025C5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentDressInfo);
		}

		// Token: 0x0601038B RID: 66443 RVA: 0x0025E3D0 File Offset: 0x0025C5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentDressInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.dressOrnamentIds_.Equals(other.dressOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601038C RID: 66444 RVA: 0x0025E420 File Offset: 0x0025C620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			num ^= this.dressOrnamentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601038D RID: 66445 RVA: 0x0025E46D File Offset: 0x0025C66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601038E RID: 66446 RVA: 0x0025E47A File Offset: 0x0025C67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601038F RID: 66447 RVA: 0x0025E484 File Offset: 0x0025C684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinId);
			}
			this.dressOrnamentIds_.WriteTo(ref output, OrnamentDressInfo._repeated_dressOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010390 RID: 66448 RVA: 0x0025E4D4 File Offset: 0x0025C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			num += this.dressOrnamentIds_.CalculateSize(OrnamentDressInfo._repeated_dressOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010391 RID: 66449 RVA: 0x0025E528 File Offset: 0x0025C728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentDressInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			this.dressOrnamentIds_.Add(other.dressOrnamentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010392 RID: 66450 RVA: 0x0025E575 File Offset: 0x0025C775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010393 RID: 66451 RVA: 0x0025E580 File Offset: 0x0025C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dressOrnamentIds_.AddEntriesFrom(ref input, OrnamentDressInfo._repeated_dressOrnamentIds_codec);
					}
				}
				else
				{
					this.RoleSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006745 RID: 26437
		private static readonly MessageParser<OrnamentDressInfo> _parser = new MessageParser<OrnamentDressInfo>(() => new OrnamentDressInfo());

		// Token: 0x04006746 RID: 26438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006747 RID: 26439
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04006748 RID: 26440
		private int roleSkinId_;

		// Token: 0x04006749 RID: 26441
		public const int DressOrnamentIdsFieldNumber = 2;

		// Token: 0x0400674A RID: 26442
		private static readonly FieldCodec<int> _repeated_dressOrnamentIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400674B RID: 26443
		private readonly RepeatedField<int> dressOrnamentIds_ = new RepeatedField<int>();
	}
}
