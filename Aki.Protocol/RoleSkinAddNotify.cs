using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B8 RID: 4280
	[NetMessage(EMessageId.RoleSkinAddNotify)]
	public sealed class RoleSkinAddNotify : IMessage<RoleSkinAddNotify>, IMessage, IEquatable<RoleSkinAddNotify>, IDeepCloneable<RoleSkinAddNotify>, IBufferMessage
	{
		// Token: 0x06016D97 RID: 93591 RVA: 0x00351C9F File Offset: 0x0034FE9F
		[NullableContext(1)]
		public static RoleSkinAddNotify Create()
		{
			return new RoleSkinAddNotify();
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x06016D98 RID: 93592 RVA: 0x00351CA6 File Offset: 0x0034FEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x06016D99 RID: 93593 RVA: 0x00351CA9 File Offset: 0x0034FEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x06016D9A RID: 93594 RVA: 0x00351CB0 File Offset: 0x0034FEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify()
		{
		}

		// Token: 0x06016D9B RID: 93595 RVA: 0x00351CC3 File Offset: 0x0034FEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify(RoleSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D9C RID: 93596 RVA: 0x00351CED File Offset: 0x0034FEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify Clone()
		{
			return new RoleSkinAddNotify(this);
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x06016D9D RID: 93597 RVA: 0x00351CF5 File Offset: 0x0034FEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x00351CFD File Offset: 0x0034FEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinAddNotify);
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x00351D0B File Offset: 0x0034FF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DA0 RID: 93600 RVA: 0x00351D40 File Offset: 0x0034FF40
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

		// Token: 0x06016DA1 RID: 93601 RVA: 0x00351D74 File Offset: 0x0034FF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DA2 RID: 93602 RVA: 0x00351D81 File Offset: 0x0034FF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DA3 RID: 93603 RVA: 0x00351D8A File Offset: 0x0034FF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DA4 RID: 93604 RVA: 0x00351DB4 File Offset: 0x0034FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x00351DED File Offset: 0x0034FFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DA6 RID: 93606 RVA: 0x00351E1B File Offset: 0x0035001B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DA7 RID: 93607 RVA: 0x00351E24 File Offset: 0x00350024
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinAddNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x04008853 RID: 34899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008854 RID: 34900
		public const int SkinIdsFieldNumber = 6;

		// Token: 0x04008855 RID: 34901
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008856 RID: 34902
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
