using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A6 RID: 5030
	public sealed class TowerDefencePhantomInfo : IMessage<TowerDefencePhantomInfo>, IMessage, IEquatable<TowerDefencePhantomInfo>, IDeepCloneable<TowerDefencePhantomInfo>, IBufferMessage
	{
		// Token: 0x0601AB09 RID: 109321 RVA: 0x003DF0BF File Offset: 0x003DD2BF
		[NullableContext(1)]
		public static TowerDefencePhantomInfo Create()
		{
			return new TowerDefencePhantomInfo();
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x0601AB0A RID: 109322 RVA: 0x003DF0C6 File Offset: 0x003DD2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefencePhantomInfo> Parser
		{
			get
			{
				return TowerDefencePhantomInfo._parser;
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x0601AB0B RID: 109323 RVA: 0x003DF0CD File Offset: 0x003DD2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x0601AB0C RID: 109324 RVA: 0x003DF0D0 File Offset: 0x003DD2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePhantomInfo.Descriptor;
			}
		}

		// Token: 0x0601AB0D RID: 109325 RVA: 0x003DF0D7 File Offset: 0x003DD2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo()
		{
		}

		// Token: 0x0601AB0E RID: 109326 RVA: 0x003DF0DF File Offset: 0x003DD2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo(TowerDefencePhantomInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB0F RID: 109327 RVA: 0x003DF11C File Offset: 0x003DD31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo Clone()
		{
			return new TowerDefencePhantomInfo(this);
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x0601AB10 RID: 109328 RVA: 0x003DF124 File Offset: 0x003DD324
		// (set) Token: 0x0601AB11 RID: 109329 RVA: 0x003DF12C File Offset: 0x003DD32C
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

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x0601AB12 RID: 109330 RVA: 0x003DF135 File Offset: 0x003DD335
		// (set) Token: 0x0601AB13 RID: 109331 RVA: 0x003DF13D File Offset: 0x003DD33D
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

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x0601AB14 RID: 109332 RVA: 0x003DF146 File Offset: 0x003DD346
		// (set) Token: 0x0601AB15 RID: 109333 RVA: 0x003DF14E File Offset: 0x003DD34E
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

		// Token: 0x0601AB16 RID: 109334 RVA: 0x003DF157 File Offset: 0x003DD357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePhantomInfo);
		}

		// Token: 0x0601AB17 RID: 109335 RVA: 0x003DF168 File Offset: 0x003DD368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePhantomInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB18 RID: 109336 RVA: 0x003DF1C4 File Offset: 0x003DD3C4
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

		// Token: 0x0601AB19 RID: 109337 RVA: 0x003DF235 File Offset: 0x003DD435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB1A RID: 109338 RVA: 0x003DF242 File Offset: 0x003DD442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB1B RID: 109339 RVA: 0x003DF24C File Offset: 0x003DD44C
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

		// Token: 0x0601AB1C RID: 109340 RVA: 0x003DF2C0 File Offset: 0x003DD4C0
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

		// Token: 0x0601AB1D RID: 109341 RVA: 0x003DF330 File Offset: 0x003DD530
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

		// Token: 0x0601AB1E RID: 109342 RVA: 0x003DF394 File Offset: 0x003DD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB1F RID: 109343 RVA: 0x003DF3A0 File Offset: 0x003DD5A0
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

		// Token: 0x04009B0A RID: 39690
		private static readonly MessageParser<TowerDefencePhantomInfo> _parser = new MessageParser<TowerDefencePhantomInfo>(() => new TowerDefencePhantomInfo());

		// Token: 0x04009B0B RID: 39691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B0C RID: 39692
		public const int IdFieldNumber = 1;

		// Token: 0x04009B0D RID: 39693
		private int id_;

		// Token: 0x04009B0E RID: 39694
		public const int LevelFieldNumber = 2;

		// Token: 0x04009B0F RID: 39695
		private int level_;

		// Token: 0x04009B10 RID: 39696
		public const int ExpFieldNumber = 3;

		// Token: 0x04009B11 RID: 39697
		private int exp_;
	}
}
