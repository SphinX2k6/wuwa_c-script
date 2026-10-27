using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B58 RID: 2904
	public sealed class NightmarePhantomInstInfo : IMessage<NightmarePhantomInstInfo>, IMessage, IEquatable<NightmarePhantomInstInfo>, IDeepCloneable<NightmarePhantomInstInfo>, IBufferMessage
	{
		// Token: 0x0600FBB6 RID: 64438 RVA: 0x0024AB83 File Offset: 0x00248D83
		[NullableContext(1)]
		public static NightmarePhantomInstInfo Create()
		{
			return new NightmarePhantomInstInfo();
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600FBB7 RID: 64439 RVA: 0x0024AB8A File Offset: 0x00248D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NightmarePhantomInstInfo> Parser
		{
			get
			{
				return NightmarePhantomInstInfo._parser;
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600FBB8 RID: 64440 RVA: 0x0024AB91 File Offset: 0x00248D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600FBB9 RID: 64441 RVA: 0x0024AB94 File Offset: 0x00248D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NightmarePhantomInstInfo.Descriptor;
			}
		}

		// Token: 0x0600FBBA RID: 64442 RVA: 0x0024AB9B File Offset: 0x00248D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo()
		{
		}

		// Token: 0x0600FBBB RID: 64443 RVA: 0x0024ABA3 File Offset: 0x00248DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo(NightmarePhantomInstInfo other) : this()
		{
			this.insId_ = other.insId_;
			this.killNum_ = other.killNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBBC RID: 64444 RVA: 0x0024ABD4 File Offset: 0x00248DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NightmarePhantomInstInfo Clone()
		{
			return new NightmarePhantomInstInfo(this);
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600FBBD RID: 64445 RVA: 0x0024ABDC File Offset: 0x00248DDC
		// (set) Token: 0x0600FBBE RID: 64446 RVA: 0x0024ABE4 File Offset: 0x00248DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InsId
		{
			get
			{
				return this.insId_;
			}
			set
			{
				this.insId_ = value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600FBBF RID: 64447 RVA: 0x0024ABED File Offset: 0x00248DED
		// (set) Token: 0x0600FBC0 RID: 64448 RVA: 0x0024ABF5 File Offset: 0x00248DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KillNum
		{
			get
			{
				return this.killNum_;
			}
			set
			{
				this.killNum_ = value;
			}
		}

		// Token: 0x0600FBC1 RID: 64449 RVA: 0x0024ABFE File Offset: 0x00248DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NightmarePhantomInstInfo);
		}

		// Token: 0x0600FBC2 RID: 64450 RVA: 0x0024AC0C File Offset: 0x00248E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NightmarePhantomInstInfo other)
		{
			return other != null && (other == this || (this.InsId == other.InsId && this.KillNum == other.KillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBC3 RID: 64451 RVA: 0x0024AC4C File Offset: 0x00248E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InsId != 0)
			{
				num ^= this.InsId.GetHashCode();
			}
			if (this.KillNum != 0L)
			{
				num ^= this.KillNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FBC4 RID: 64452 RVA: 0x0024ACA4 File Offset: 0x00248EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBC5 RID: 64453 RVA: 0x0024ACB1 File Offset: 0x00248EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBC6 RID: 64454 RVA: 0x0024ACBC File Offset: 0x00248EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InsId);
			}
			if (this.KillNum != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FBC7 RID: 64455 RVA: 0x0024AD14 File Offset: 0x00248F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InsId);
			}
			if (this.KillNum != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FBC8 RID: 64456 RVA: 0x0024AD6C File Offset: 0x00248F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NightmarePhantomInstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InsId != 0)
			{
				this.InsId = other.InsId;
			}
			if (other.KillNum != 0L)
			{
				this.KillNum = other.KillNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FBC9 RID: 64457 RVA: 0x0024ADBC File Offset: 0x00248FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBCA RID: 64458 RVA: 0x0024ADC8 File Offset: 0x00248FC8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KillNum = input.ReadInt64();
					}
				}
				else
				{
					this.InsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006495 RID: 25749
		private static readonly MessageParser<NightmarePhantomInstInfo> _parser = new MessageParser<NightmarePhantomInstInfo>(() => new NightmarePhantomInstInfo());

		// Token: 0x04006496 RID: 25750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006497 RID: 25751
		public const int InsIdFieldNumber = 1;

		// Token: 0x04006498 RID: 25752
		private int insId_;

		// Token: 0x04006499 RID: 25753
		public const int KillNumFieldNumber = 2;

		// Token: 0x0400649A RID: 25754
		private long killNum_;
	}
}
