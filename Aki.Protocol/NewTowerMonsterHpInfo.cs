using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3C RID: 2876
	public sealed class NewTowerMonsterHpInfo : IMessage<NewTowerMonsterHpInfo>, IMessage, IEquatable<NewTowerMonsterHpInfo>, IDeepCloneable<NewTowerMonsterHpInfo>, IBufferMessage
	{
		// Token: 0x0600F98E RID: 63886 RVA: 0x002463D5 File Offset: 0x002445D5
		[NullableContext(1)]
		public static NewTowerMonsterHpInfo Create()
		{
			return new NewTowerMonsterHpInfo();
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600F98F RID: 63887 RVA: 0x002463DC File Offset: 0x002445DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerMonsterHpInfo> Parser
		{
			get
			{
				return NewTowerMonsterHpInfo._parser;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600F990 RID: 63888 RVA: 0x002463E3 File Offset: 0x002445E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600F991 RID: 63889 RVA: 0x002463E6 File Offset: 0x002445E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMonsterHpInfo.Descriptor;
			}
		}

		// Token: 0x0600F992 RID: 63890 RVA: 0x002463ED File Offset: 0x002445ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfo()
		{
		}

		// Token: 0x0600F993 RID: 63891 RVA: 0x002463F8 File Offset: 0x002445F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfo(NewTowerMonsterHpInfo other) : this()
		{
			this.waveConfigId_ = other.waveConfigId_;
			this.incId_ = other.incId_;
			this.maxHp_ = other.maxHp_;
			this.curHp_ = other.curHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F994 RID: 63892 RVA: 0x0024644C File Offset: 0x0024464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfo Clone()
		{
			return new NewTowerMonsterHpInfo(this);
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600F995 RID: 63893 RVA: 0x00246454 File Offset: 0x00244654
		// (set) Token: 0x0600F996 RID: 63894 RVA: 0x0024645C File Offset: 0x0024465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveConfigId
		{
			get
			{
				return this.waveConfigId_;
			}
			set
			{
				this.waveConfigId_ = value;
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600F997 RID: 63895 RVA: 0x00246465 File Offset: 0x00244665
		// (set) Token: 0x0600F998 RID: 63896 RVA: 0x0024646D File Offset: 0x0024466D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600F999 RID: 63897 RVA: 0x00246476 File Offset: 0x00244676
		// (set) Token: 0x0600F99A RID: 63898 RVA: 0x0024647E File Offset: 0x0024467E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MaxHp
		{
			get
			{
				return this.maxHp_;
			}
			set
			{
				this.maxHp_ = value;
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600F99B RID: 63899 RVA: 0x00246487 File Offset: 0x00244687
		// (set) Token: 0x0600F99C RID: 63900 RVA: 0x0024648F File Offset: 0x0024468F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurHp
		{
			get
			{
				return this.curHp_;
			}
			set
			{
				this.curHp_ = value;
			}
		}

		// Token: 0x0600F99D RID: 63901 RVA: 0x00246498 File Offset: 0x00244698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMonsterHpInfo);
		}

		// Token: 0x0600F99E RID: 63902 RVA: 0x002464A8 File Offset: 0x002446A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMonsterHpInfo other)
		{
			return other != null && (other == this || (this.WaveConfigId == other.WaveConfigId && this.IncId == other.IncId && this.MaxHp == other.MaxHp && this.CurHp == other.CurHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F99F RID: 63903 RVA: 0x00246514 File Offset: 0x00244714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveConfigId != 0)
			{
				num ^= this.WaveConfigId.GetHashCode();
			}
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.MaxHp != 0L)
			{
				num ^= this.MaxHp.GetHashCode();
			}
			if (this.CurHp != 0L)
			{
				num ^= this.CurHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F9A0 RID: 63904 RVA: 0x0024659E File Offset: 0x0024479E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9A1 RID: 63905 RVA: 0x002465AB File Offset: 0x002447AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9A2 RID: 63906 RVA: 0x002465B4 File Offset: 0x002447B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveConfigId);
			}
			if (this.IncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.IncId);
			}
			if (this.MaxHp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.MaxHp);
			}
			if (this.CurHp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CurHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9A3 RID: 63907 RVA: 0x00246644 File Offset: 0x00244844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveConfigId);
			}
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this.MaxHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxHp);
			}
			if (this.CurHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F9A4 RID: 63908 RVA: 0x002466CC File Offset: 0x002448CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMonsterHpInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveConfigId != 0)
			{
				this.WaveConfigId = other.WaveConfigId;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			if (other.MaxHp != 0L)
			{
				this.MaxHp = other.MaxHp;
			}
			if (other.CurHp != 0L)
			{
				this.CurHp = other.CurHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x00246744 File Offset: 0x00244944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9A6 RID: 63910 RVA: 0x00246750 File Offset: 0x00244950
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.WaveConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxHp = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.CurHp = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040063F7 RID: 25591
		private static readonly MessageParser<NewTowerMonsterHpInfo> _parser = new MessageParser<NewTowerMonsterHpInfo>(() => new NewTowerMonsterHpInfo());

		// Token: 0x040063F8 RID: 25592
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063F9 RID: 25593
		public const int WaveConfigIdFieldNumber = 1;

		// Token: 0x040063FA RID: 25594
		private int waveConfigId_;

		// Token: 0x040063FB RID: 25595
		public const int IncIdFieldNumber = 2;

		// Token: 0x040063FC RID: 25596
		private long incId_;

		// Token: 0x040063FD RID: 25597
		public const int MaxHpFieldNumber = 3;

		// Token: 0x040063FE RID: 25598
		private long maxHp_;

		// Token: 0x040063FF RID: 25599
		public const int CurHpFieldNumber = 4;

		// Token: 0x04006400 RID: 25600
		private long curHp_;
	}
}
