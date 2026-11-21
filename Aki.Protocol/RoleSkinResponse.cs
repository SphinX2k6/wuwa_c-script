using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AE RID: 4270
	[NetMessage(EMessageId.RoleSkinResponse)]
	public sealed class RoleSkinResponse : IMessage<RoleSkinResponse>, IMessage, IEquatable<RoleSkinResponse>, IDeepCloneable<RoleSkinResponse>, IBufferMessage
	{
		// Token: 0x06016D26 RID: 93478 RVA: 0x0035134E File Offset: 0x0034F54E
		[NullableContext(1)]
		public static RoleSkinResponse Create()
		{
			return new RoleSkinResponse();
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x06016D27 RID: 93479 RVA: 0x00351355 File Offset: 0x0034F555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x06016D28 RID: 93480 RVA: 0x00351358 File Offset: 0x0034F558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinResponse.Descriptor;
			}
		}

		// Token: 0x06016D29 RID: 93481 RVA: 0x0035135F File Offset: 0x0034F55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse()
		{
		}

		// Token: 0x06016D2A RID: 93482 RVA: 0x00351372 File Offset: 0x0034F572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse(RoleSkinResponse other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D2B RID: 93483 RVA: 0x0035139C File Offset: 0x0034F59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse Clone()
		{
			return new RoleSkinResponse(this);
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06016D2C RID: 93484 RVA: 0x003513A4 File Offset: 0x0034F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016D2D RID: 93485 RVA: 0x003513AC File Offset: 0x0034F5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinResponse);
		}

		// Token: 0x06016D2E RID: 93486 RVA: 0x003513BA File Offset: 0x0034F5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinResponse other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x003513F0 File Offset: 0x0034F5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x00351424 File Offset: 0x0034F624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D31 RID: 93489 RVA: 0x00351431 File Offset: 0x0034F631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D32 RID: 93490 RVA: 0x0035143A File Offset: 0x0034F63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinResponse._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D33 RID: 93491 RVA: 0x00351464 File Offset: 0x0034F664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinResponse._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D34 RID: 93492 RVA: 0x0035149D File Offset: 0x0034F69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x003514CB File Offset: 0x0034F6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x003514D4 File Offset: 0x0034F6D4
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinResponse._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x04008897 RID: 34967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008898 RID: 34968
		public const int SkinIdsFieldNumber = 11;

		// Token: 0x04008899 RID: 34969
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400889A RID: 34970
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
