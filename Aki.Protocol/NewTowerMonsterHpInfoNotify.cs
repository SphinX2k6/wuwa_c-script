using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2C RID: 2860
	[NetMessage(EMessageId.NewTowerMonsterHpInfoNotify)]
	public sealed class NewTowerMonsterHpInfoNotify : IMessage<NewTowerMonsterHpInfoNotify>, IMessage, IEquatable<NewTowerMonsterHpInfoNotify>, IDeepCloneable<NewTowerMonsterHpInfoNotify>, IBufferMessage
	{
		// Token: 0x0600F88E RID: 63630 RVA: 0x002445D4 File Offset: 0x002427D4
		[NullableContext(1)]
		public static NewTowerMonsterHpInfoNotify Create()
		{
			return new NewTowerMonsterHpInfoNotify();
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600F88F RID: 63631 RVA: 0x002445DB File Offset: 0x002427DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600F890 RID: 63632 RVA: 0x002445DE File Offset: 0x002427DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMonsterHpInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x002445E5 File Offset: 0x002427E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify()
		{
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x002445F8 File Offset: 0x002427F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify(NewTowerMonsterHpInfoNotify other) : this()
		{
			this.monsterHpInfos_ = other.monsterHpInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F893 RID: 63635 RVA: 0x00244622 File Offset: 0x00242822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify Clone()
		{
			return new NewTowerMonsterHpInfoNotify(this);
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x0024462A File Offset: 0x0024282A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerMonsterHpInfo> MonsterHpInfos
		{
			get
			{
				return this.monsterHpInfos_;
			}
		}

		// Token: 0x0600F895 RID: 63637 RVA: 0x00244632 File Offset: 0x00242832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMonsterHpInfoNotify);
		}

		// Token: 0x0600F896 RID: 63638 RVA: 0x00244640 File Offset: 0x00242840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMonsterHpInfoNotify other)
		{
			return other != null && (other == this || (this.monsterHpInfos_.Equals(other.monsterHpInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x00244674 File Offset: 0x00242874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monsterHpInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x002446A8 File Offset: 0x002428A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x002446B5 File Offset: 0x002428B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F89A RID: 63642 RVA: 0x002446BE File Offset: 0x002428BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsterHpInfos_.WriteTo(ref output, NewTowerMonsterHpInfoNotify._repeated_monsterHpInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x002446E8 File Offset: 0x002428E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsterHpInfos_.CalculateSize(NewTowerMonsterHpInfoNotify._repeated_monsterHpInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x00244721 File Offset: 0x00242921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMonsterHpInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.monsterHpInfos_.Add(other.monsterHpInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x0024474F File Offset: 0x0024294F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F89E RID: 63646 RVA: 0x00244758 File Offset: 0x00242958
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.monsterHpInfos_.AddEntriesFrom(ref input, NewTowerMonsterHpInfoNotify._repeated_monsterHpInfos_codec);
				}
			}
		}

		// Token: 0x0400640A RID: 25610
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400640B RID: 25611
		public const int MonsterHpInfosFieldNumber = 3;

		// Token: 0x0400640C RID: 25612
		private static readonly FieldCodec<NewTowerMonsterHpInfo> _repeated_monsterHpInfos_codec = FieldCodec.ForMessage<NewTowerMonsterHpInfo>(26U, NewTowerMonsterHpInfo.Parser);

		// Token: 0x0400640D RID: 25613
		private readonly RepeatedField<NewTowerMonsterHpInfo> monsterHpInfos_ = new RepeatedField<NewTowerMonsterHpInfo>();
	}
}
