using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000219 RID: 537
	public sealed class CalabashCfg : IMessage<CalabashCfg>, IMessage, IEquatable<CalabashCfg>, IDeepCloneable<CalabashCfg>, IBufferMessage
	{
		// Token: 0x06003ADB RID: 15067 RVA: 0x00092991 File Offset: 0x00090B91
		[NullableContext(1)]
		public static CalabashCfg Create()
		{
			return new CalabashCfg();
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x00092998 File Offset: 0x00090B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x0009299B File Offset: 0x00090B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashCfg.Descriptor;
			}
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x000929A2 File Offset: 0x00090BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg()
		{
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x000929B8 File Offset: 0x00090BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg(CalabashCfg other) : this()
		{
			this.levelUpExp_ = other.levelUpExp_;
			this.levelUpCondition_ = other.levelUpCondition_;
			this.catchGain_ = other.catchGain_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00092A05 File Offset: 0x00090C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg Clone()
		{
			return new CalabashCfg(this);
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x00092A0D File Offset: 0x00090C0D
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00092A15 File Offset: 0x00090C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelUpExp
		{
			get
			{
				return this.levelUpExp_;
			}
			set
			{
				this.levelUpExp_ = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00092A1E File Offset: 0x00090C1E
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x00092A26 File Offset: 0x00090C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelUpCondition
		{
			get
			{
				return this.levelUpCondition_;
			}
			set
			{
				this.levelUpCondition_ = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00092A2F File Offset: 0x00090C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CatchGain
		{
			get
			{
				return this.catchGain_;
			}
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00092A37 File Offset: 0x00090C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashCfg);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00092A48 File Offset: 0x00090C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashCfg other)
		{
			return other != null && (other == this || (this.LevelUpExp == other.LevelUpExp && this.LevelUpCondition == other.LevelUpCondition && this.CatchGain.Equals(other.CatchGain) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x00092AA8 File Offset: 0x00090CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelUpExp != 0)
			{
				num ^= this.LevelUpExp.GetHashCode();
			}
			if (this.LevelUpCondition != 0)
			{
				num ^= this.LevelUpCondition.GetHashCode();
			}
			num ^= this.CatchGain.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00092B0E File Offset: 0x00090D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x00092B1B File Offset: 0x00090D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00092B24 File Offset: 0x00090D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelUpExp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelUpExp);
			}
			if (this.LevelUpCondition != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelUpCondition);
			}
			this.catchGain_.WriteTo(ref output, CalabashCfg._map_catchGain_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00092B90 File Offset: 0x00090D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelUpExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelUpExp);
			}
			if (this.LevelUpCondition != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelUpCondition);
			}
			num += this.catchGain_.CalculateSize(CalabashCfg._map_catchGain_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00092BFC File Offset: 0x00090DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashCfg other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelUpExp != 0)
			{
				this.LevelUpExp = other.LevelUpExp;
			}
			if (other.LevelUpCondition != 0)
			{
				this.LevelUpCondition = other.LevelUpCondition;
			}
			this.catchGain_.MergeFrom(other.catchGain_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00092C5D File Offset: 0x00090E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x00092C68 File Offset: 0x00090E68
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
					if (num != 24U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.catchGain_.AddEntriesFrom(ref input, CalabashCfg._map_catchGain_codec);
						}
					}
					else
					{
						this.LevelUpCondition = input.ReadInt32();
					}
				}
				else
				{
					this.LevelUpExp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BFA RID: 11258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BFB RID: 11259
		public const int LevelUpExpFieldNumber = 1;

		// Token: 0x04002BFC RID: 11260
		private int levelUpExp_;

		// Token: 0x04002BFD RID: 11261
		public const int LevelUpConditionFieldNumber = 3;

		// Token: 0x04002BFE RID: 11262
		private int levelUpCondition_;

		// Token: 0x04002BFF RID: 11263
		public const int CatchGainFieldNumber = 4;

		// Token: 0x04002C00 RID: 11264
		private static readonly MapField<int, int>.Codec _map_catchGain_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04002C01 RID: 11265
		private readonly MapField<int, int> catchGain_ = new MapField<int, int>();
	}
}
