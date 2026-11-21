using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001419 RID: 5145
	public sealed class TowerDefencePhantomInfo : IMessage<TowerDefencePhantomInfo>, IMessage, IEquatable<TowerDefencePhantomInfo>, IDeepCloneable<TowerDefencePhantomInfo>, IBufferMessage
	{
		// Token: 0x0601B594 RID: 112020 RVA: 0x003FA37F File Offset: 0x003F857F
		[NullableContext(1)]
		public static TowerDefencePhantomInfo Create()
		{
			return new TowerDefencePhantomInfo();
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x0601B595 RID: 112021 RVA: 0x003FA386 File Offset: 0x003F8586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefencePhantomInfo> Parser
		{
			get
			{
				return TowerDefencePhantomInfo._parser;
			}
		}

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x0601B596 RID: 112022 RVA: 0x003FA38D File Offset: 0x003F858D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x0601B597 RID: 112023 RVA: 0x003FA390 File Offset: 0x003F8590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePhantomInfo.Descriptor;
			}
		}

		// Token: 0x0601B598 RID: 112024 RVA: 0x003FA397 File Offset: 0x003F8597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo()
		{
		}

		// Token: 0x0601B599 RID: 112025 RVA: 0x003FA39F File Offset: 0x003F859F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo(TowerDefencePhantomInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B59A RID: 112026 RVA: 0x003FA3DC File Offset: 0x003F85DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo Clone()
		{
			return new TowerDefencePhantomInfo(this);
		}

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x003FA3E4 File Offset: 0x003F85E4
		// (set) Token: 0x0601B59C RID: 112028 RVA: 0x003FA3EC File Offset: 0x003F85EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x0601B59D RID: 112029 RVA: 0x003FA3F5 File Offset: 0x003F85F5
		// (set) Token: 0x0601B59E RID: 112030 RVA: 0x003FA3FD File Offset: 0x003F85FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x0601B59F RID: 112031 RVA: 0x003FA406 File Offset: 0x003F8606
		// (set) Token: 0x0601B5A0 RID: 112032 RVA: 0x003FA40E File Offset: 0x003F860E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x0601B5A1 RID: 112033 RVA: 0x003FA417 File Offset: 0x003F8617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePhantomInfo);
		}

		// Token: 0x0601B5A2 RID: 112034 RVA: 0x003FA428 File Offset: 0x003F8628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePhantomInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5A3 RID: 112035 RVA: 0x003FA484 File Offset: 0x003F8684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5A4 RID: 112036 RVA: 0x003FA4F5 File Offset: 0x003F86F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5A5 RID: 112037 RVA: 0x003FA502 File Offset: 0x003F8702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5A6 RID: 112038 RVA: 0x003FA50C File Offset: 0x003F870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5A7 RID: 112039 RVA: 0x003FA580 File Offset: 0x003F8780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5A8 RID: 112040 RVA: 0x003FA5F0 File Offset: 0x003F87F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePhantomInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5A9 RID: 112041 RVA: 0x003FA654 File Offset: 0x003F8854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x003FA660 File Offset: 0x003F8860
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Exp = input.ReadInt32();
						}
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F51 RID: 40785
		private static readonly MessageParser<TowerDefencePhantomInfo> _parser = new MessageParser<TowerDefencePhantomInfo>(() => new TowerDefencePhantomInfo());

		// Token: 0x04009F52 RID: 40786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F53 RID: 40787
		public const int IdFieldNumber = 1;

		// Token: 0x04009F54 RID: 40788
		private int id_;

		// Token: 0x04009F55 RID: 40789
		public const int LevelFieldNumber = 2;

		// Token: 0x04009F56 RID: 40790
		private int level_;

		// Token: 0x04009F57 RID: 40791
		public const int ExpFieldNumber = 3;

		// Token: 0x04009F58 RID: 40792
		private int exp_;
	}
}
