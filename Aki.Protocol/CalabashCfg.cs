using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021E RID: 542
	public sealed class CalabashCfg : IMessage<CalabashCfg>, IMessage, IEquatable<CalabashCfg>, IDeepCloneable<CalabashCfg>, IBufferMessage
	{
		// Token: 0x06003B80 RID: 15232 RVA: 0x000945A9 File Offset: 0x000927A9
		[NullableContext(1)]
		public static CalabashCfg Create()
		{
			return new CalabashCfg();
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x000945B0 File Offset: 0x000927B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x000945B3 File Offset: 0x000927B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashCfg.Descriptor;
			}
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x000945BA File Offset: 0x000927BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg()
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x000945D0 File Offset: 0x000927D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg(CalabashCfg other) : this()
		{
			this.levelUpExp_ = other.levelUpExp_;
			this.levelUpCondition_ = other.levelUpCondition_;
			this.catchGain_ = other.catchGain_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x0009461D File Offset: 0x0009281D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg Clone()
		{
			return new CalabashCfg(this);
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00094625 File Offset: 0x00092825
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x0009462D File Offset: 0x0009282D
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00094636 File Offset: 0x00092836
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x0009463E File Offset: 0x0009283E
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

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x00094647 File Offset: 0x00092847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CatchGain
		{
			get
			{
				return this.catchGain_;
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x0009464F File Offset: 0x0009284F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashCfg);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00094660 File Offset: 0x00092860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashCfg other)
		{
			return other != null && (other == this || (this.LevelUpExp == other.LevelUpExp && this.LevelUpCondition == other.LevelUpCondition && this.CatchGain.Equals(other.CatchGain) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x000946C0 File Offset: 0x000928C0
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

		// Token: 0x06003B8E RID: 15246 RVA: 0x00094726 File Offset: 0x00092926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00094733 File Offset: 0x00092933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x0009473C File Offset: 0x0009293C
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

		// Token: 0x06003B91 RID: 15249 RVA: 0x000947A8 File Offset: 0x000929A8
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

		// Token: 0x06003B92 RID: 15250 RVA: 0x00094814 File Offset: 0x00092A14
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

		// Token: 0x06003B93 RID: 15251 RVA: 0x00094875 File Offset: 0x00092A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00094880 File Offset: 0x00092A80
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

		// Token: 0x04002C7C RID: 11388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C7D RID: 11389
		public const int LevelUpExpFieldNumber = 1;

		// Token: 0x04002C7E RID: 11390
		private int levelUpExp_;

		// Token: 0x04002C7F RID: 11391
		public const int LevelUpConditionFieldNumber = 3;

		// Token: 0x04002C80 RID: 11392
		private int levelUpCondition_;

		// Token: 0x04002C81 RID: 11393
		public const int CatchGainFieldNumber = 4;

		// Token: 0x04002C82 RID: 11394
		private static readonly MapField<int, int>.Codec _map_catchGain_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04002C83 RID: 11395
		private readonly MapField<int, int> catchGain_ = new MapField<int, int>();
	}
}
