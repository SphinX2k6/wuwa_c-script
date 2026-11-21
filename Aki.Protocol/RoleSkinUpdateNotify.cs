using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B4 RID: 4276
	[NetMessage(EMessageId.RoleSkinUpdateNotify)]
	public sealed class RoleSkinUpdateNotify : IMessage<RoleSkinUpdateNotify>, IMessage, IEquatable<RoleSkinUpdateNotify>, IDeepCloneable<RoleSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016D96 RID: 93590 RVA: 0x00351F7E File Offset: 0x0035017E
		[NullableContext(1)]
		public static RoleSkinUpdateNotify Create()
		{
			return new RoleSkinUpdateNotify();
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x06016D97 RID: 93591 RVA: 0x00351F85 File Offset: 0x00350185
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
		// (get) Token: 0x06016D98 RID: 93592 RVA: 0x00351F88 File Offset: 0x00350188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016D99 RID: 93593 RVA: 0x00351F8F File Offset: 0x0035018F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify()
		{
		}

		// Token: 0x06016D9A RID: 93594 RVA: 0x00351FA2 File Offset: 0x003501A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify(RoleSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D9B RID: 93595 RVA: 0x00351FCC File Offset: 0x003501CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify Clone()
		{
			return new RoleSkinUpdateNotify(this);
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x06016D9C RID: 93596 RVA: 0x00351FD4 File Offset: 0x003501D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016D9D RID: 93597 RVA: 0x00351FDC File Offset: 0x003501DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinUpdateNotify);
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x00351FEA File Offset: 0x003501EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x00352020 File Offset: 0x00350220
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

		// Token: 0x06016DA0 RID: 93600 RVA: 0x00352054 File Offset: 0x00350254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DA1 RID: 93601 RVA: 0x00352061 File Offset: 0x00350261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DA2 RID: 93602 RVA: 0x0035206A File Offset: 0x0035026A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DA3 RID: 93603 RVA: 0x00352094 File Offset: 0x00350294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DA4 RID: 93604 RVA: 0x003520CD File Offset: 0x003502CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x003520FB File Offset: 0x003502FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DA6 RID: 93606 RVA: 0x00352104 File Offset: 0x00350304
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x040088AE RID: 34990
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088AF RID: 34991
		public const int SkinIdsFieldNumber = 9;

		// Token: 0x040088B0 RID: 34992
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040088B1 RID: 34993
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
