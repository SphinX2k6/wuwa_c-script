using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2B RID: 2859
	public sealed class NewTowerMonsterHpInfo : IMessage<NewTowerMonsterHpInfo>, IMessage, IEquatable<NewTowerMonsterHpInfo>, IDeepCloneable<NewTowerMonsterHpInfo>, IBufferMessage
	{
		// Token: 0x0600F874 RID: 63604 RVA: 0x002441B9 File Offset: 0x002423B9
		[NullableContext(1)]
		public static NewTowerMonsterHpInfo Create()
		{
			return new NewTowerMonsterHpInfo();
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600F875 RID: 63605 RVA: 0x002441C0 File Offset: 0x002423C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerMonsterHpInfo> Parser
		{
			get
			{
				return NewTowerMonsterHpInfo._parser;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x002441C7 File Offset: 0x002423C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600F877 RID: 63607 RVA: 0x002441CA File Offset: 0x002423CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMonsterHpInfo.Descriptor;
			}
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x002441D1 File Offset: 0x002423D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfo()
		{
		}

		// Token: 0x0600F879 RID: 63609 RVA: 0x002441DC File Offset: 0x002423DC
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

		// Token: 0x0600F87A RID: 63610 RVA: 0x00244230 File Offset: 0x00242430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMonsterHpInfo Clone()
		{
			return new NewTowerMonsterHpInfo(this);
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600F87B RID: 63611 RVA: 0x00244238 File Offset: 0x00242438
		// (set) Token: 0x0600F87C RID: 63612 RVA: 0x00244240 File Offset: 0x00242440
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

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600F87D RID: 63613 RVA: 0x00244249 File Offset: 0x00242449
		// (set) Token: 0x0600F87E RID: 63614 RVA: 0x00244251 File Offset: 0x00242451
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

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600F87F RID: 63615 RVA: 0x0024425A File Offset: 0x0024245A
		// (set) Token: 0x0600F880 RID: 63616 RVA: 0x00244262 File Offset: 0x00242462
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

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600F881 RID: 63617 RVA: 0x0024426B File Offset: 0x0024246B
		// (set) Token: 0x0600F882 RID: 63618 RVA: 0x00244273 File Offset: 0x00242473
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

		// Token: 0x0600F883 RID: 63619 RVA: 0x0024427C File Offset: 0x0024247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMonsterHpInfo);
		}

		// Token: 0x0600F884 RID: 63620 RVA: 0x0024428C File Offset: 0x0024248C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMonsterHpInfo other)
		{
			return other != null && (other == this || (this.WaveConfigId == other.WaveConfigId && this.IncId == other.IncId && this.MaxHp == other.MaxHp && this.CurHp == other.CurHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x002442F8 File Offset: 0x002424F8
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

		// Token: 0x0600F886 RID: 63622 RVA: 0x00244382 File Offset: 0x00242582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x0024438F File Offset: 0x0024258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x00244398 File Offset: 0x00242598
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

		// Token: 0x0600F889 RID: 63625 RVA: 0x00244428 File Offset: 0x00242628
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

		// Token: 0x0600F88A RID: 63626 RVA: 0x002444B0 File Offset: 0x002426B0
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

		// Token: 0x0600F88B RID: 63627 RVA: 0x00244528 File Offset: 0x00242728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x00244534 File Offset: 0x00242734
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

		// Token: 0x04006400 RID: 25600
		private static readonly MessageParser<NewTowerMonsterHpInfo> _parser = new MessageParser<NewTowerMonsterHpInfo>(() => new NewTowerMonsterHpInfo());

		// Token: 0x04006401 RID: 25601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006402 RID: 25602
		public const int WaveConfigIdFieldNumber = 1;

		// Token: 0x04006403 RID: 25603
		private int waveConfigId_;

		// Token: 0x04006404 RID: 25604
		public const int IncIdFieldNumber = 2;

		// Token: 0x04006405 RID: 25605
		private long incId_;

		// Token: 0x04006406 RID: 25606
		public const int MaxHpFieldNumber = 3;

		// Token: 0x04006407 RID: 25607
		private long maxHp_;

		// Token: 0x04006408 RID: 25608
		public const int CurHpFieldNumber = 4;

		// Token: 0x04006409 RID: 25609
		private long curHp_;
	}
}
