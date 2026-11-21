using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000240 RID: 576
	public sealed class CaughtInfo : IMessage<CaughtInfo>, IMessage, IEquatable<CaughtInfo>, IDeepCloneable<CaughtInfo>, IBufferMessage
	{
		// Token: 0x06003E2E RID: 15918 RVA: 0x0009A18E File Offset: 0x0009838E
		[NullableContext(1)]
		public static CaughtInfo Create()
		{
			return new CaughtInfo();
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x0009A195 File Offset: 0x00098395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x0009A198 File Offset: 0x00098398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtInfo.Descriptor;
			}
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0009A19F File Offset: 0x0009839F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo()
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0009A1A8 File Offset: 0x000983A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo(CaughtInfo other) : this()
		{
			this.attacker_ = other.attacker_;
			this.caughtInfoId_ = other.caughtInfoId_;
			this.isEnd_ = other.isEnd_;
			this.fightState_ = other.fightState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0009A1FC File Offset: 0x000983FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Clone()
		{
			return new CaughtInfo(this);
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x0009A204 File Offset: 0x00098404
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x0009A20C File Offset: 0x0009840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Attacker
		{
			get
			{
				return this.attacker_;
			}
			set
			{
				this.attacker_ = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x0009A215 File Offset: 0x00098415
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x0009A21D File Offset: 0x0009841D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CaughtInfoId
		{
			get
			{
				return this.caughtInfoId_;
			}
			set
			{
				this.caughtInfoId_ = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x0009A226 File Offset: 0x00098426
		// (set) Token: 0x06003E39 RID: 15929 RVA: 0x0009A22E File Offset: 0x0009842E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnd
		{
			get
			{
				return this.isEnd_;
			}
			set
			{
				this.isEnd_ = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x0009A237 File Offset: 0x00098437
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x0009A23F File Offset: 0x0009843F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0009A248 File Offset: 0x00098448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtInfo);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x0009A258 File Offset: 0x00098458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtInfo other)
		{
			return other != null && (other == this || (this.Attacker == other.Attacker && this.CaughtInfoId == other.CaughtInfoId && this.IsEnd == other.IsEnd && this.FightState == other.FightState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0009A2C4 File Offset: 0x000984C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Attacker != 0L)
			{
				num ^= this.Attacker.GetHashCode();
			}
			if (this.CaughtInfoId != 0L)
			{
				num ^= this.CaughtInfoId.GetHashCode();
			}
			if (this.IsEnd)
			{
				num ^= this.IsEnd.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0009A34E File Offset: 0x0009854E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0009A35B File Offset: 0x0009855B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x0009A364 File Offset: 0x00098564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Attacker != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Attacker);
			}
			if (this.CaughtInfoId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CaughtInfoId);
			}
			if (this.IsEnd)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsEnd);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FightState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x0009A3F4 File Offset: 0x000985F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Attacker != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Attacker);
			}
			if (this.CaughtInfoId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CaughtInfoId);
			}
			if (this.IsEnd)
			{
				num += 2;
			}
			if (this.FightState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0009A470 File Offset: 0x00098670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Attacker != 0L)
			{
				this.Attacker = other.Attacker;
			}
			if (other.CaughtInfoId != 0L)
			{
				this.CaughtInfoId = other.CaughtInfoId;
			}
			if (other.IsEnd)
			{
				this.IsEnd = other.IsEnd;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x0009A4E8 File Offset: 0x000986E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x0009A4F4 File Offset: 0x000986F4
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
						this.Attacker = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.CaughtInfoId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsEnd = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D33 RID: 11571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D34 RID: 11572
		public const int AttackerFieldNumber = 1;

		// Token: 0x04002D35 RID: 11573
		private long attacker_;

		// Token: 0x04002D36 RID: 11574
		public const int CaughtInfoIdFieldNumber = 2;

		// Token: 0x04002D37 RID: 11575
		private long caughtInfoId_;

		// Token: 0x04002D38 RID: 11576
		public const int IsEndFieldNumber = 3;

		// Token: 0x04002D39 RID: 11577
		private bool isEnd_;

		// Token: 0x04002D3A RID: 11578
		public const int FightStateFieldNumber = 4;

		// Token: 0x04002D3B RID: 11579
		private int fightState_;
	}
}
