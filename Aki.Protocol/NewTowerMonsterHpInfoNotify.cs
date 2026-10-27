using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3D RID: 2877
	[NetMessage(EMessageId.NewTowerMonsterHpInfoNotify)]
	public sealed class NewTowerMonsterHpInfoNotify : IMessage<NewTowerMonsterHpInfoNotify>, IMessage, IEquatable<NewTowerMonsterHpInfoNotify>, IDeepCloneable<NewTowerMonsterHpInfoNotify>, IBufferMessage
	{
		// Token: 0x0600F9A8 RID: 63912 RVA: 0x002467F0 File Offset: 0x002449F0
		[NullableContext(1)]
		public static NewTowerMonsterHpInfoNotify Create()
		{
			return new NewTowerMonsterHpInfoNotify();
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600F9A9 RID: 63913 RVA: 0x002467F7 File Offset: 0x002449F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600F9AA RID: 63914 RVA: 0x002467FA File Offset: 0x002449FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMonsterHpInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600F9AB RID: 63915 RVA: 0x00246801 File Offset: 0x00244A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify()
		{
		}

		// Token: 0x0600F9AC RID: 63916 RVA: 0x00246814 File Offset: 0x00244A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify(NewTowerMonsterHpInfoNotify other) : this()
		{
			this.monsterHpInfos_ = other.monsterHpInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9AD RID: 63917 RVA: 0x0024683E File Offset: 0x00244A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfoNotify Clone()
		{
			return new NewTowerMonsterHpInfoNotify(this);
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600F9AE RID: 63918 RVA: 0x00246846 File Offset: 0x00244A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerMonsterHpInfo> MonsterHpInfos
		{
			get
			{
				return this.monsterHpInfos_;
			}
		}

		// Token: 0x0600F9AF RID: 63919 RVA: 0x0024684E File Offset: 0x00244A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMonsterHpInfoNotify);
		}

		// Token: 0x0600F9B0 RID: 63920 RVA: 0x0024685C File Offset: 0x00244A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMonsterHpInfoNotify other)
		{
			return other != null && (other == this || (this.monsterHpInfos_.Equals(other.monsterHpInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9B1 RID: 63921 RVA: 0x00246890 File Offset: 0x00244A90
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

		// Token: 0x0600F9B2 RID: 63922 RVA: 0x002468C4 File Offset: 0x00244AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9B3 RID: 63923 RVA: 0x002468D1 File Offset: 0x00244AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9B4 RID: 63924 RVA: 0x002468DA File Offset: 0x00244ADA
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

		// Token: 0x0600F9B5 RID: 63925 RVA: 0x00246904 File Offset: 0x00244B04
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

		// Token: 0x0600F9B6 RID: 63926 RVA: 0x0024693D File Offset: 0x00244B3D
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

		// Token: 0x0600F9B7 RID: 63927 RVA: 0x0024696B File Offset: 0x00244B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9B8 RID: 63928 RVA: 0x00246974 File Offset: 0x00244B74
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

		// Token: 0x04006401 RID: 25601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006402 RID: 25602
		public const int MonsterHpInfosFieldNumber = 3;

		// Token: 0x04006403 RID: 25603
		private static readonly FieldCodec<NewTowerMonsterHpInfo> _repeated_monsterHpInfos_codec = FieldCodec.ForMessage<NewTowerMonsterHpInfo>(26U, NewTowerMonsterHpInfo.Parser);

		// Token: 0x04006404 RID: 25604
		private readonly RepeatedField<NewTowerMonsterHpInfo> monsterHpInfos_ = new RepeatedField<NewTowerMonsterHpInfo>();
	}
}
