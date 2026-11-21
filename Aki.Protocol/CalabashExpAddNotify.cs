using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000222 RID: 546
	[NetMessage(EMessageId.CalabashExpAddNotify)]
	public sealed class CalabashExpAddNotify : IMessage<CalabashExpAddNotify>, IMessage, IEquatable<CalabashExpAddNotify>, IDeepCloneable<CalabashExpAddNotify>, IBufferMessage
	{
		// Token: 0x06003BD7 RID: 15319 RVA: 0x00095212 File Offset: 0x00093412
		[NullableContext(1)]
		public static CalabashExpAddNotify Create()
		{
			return new CalabashExpAddNotify();
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x00095219 File Offset: 0x00093419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x0009521C File Offset: 0x0009341C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashExpAddNotify.Descriptor;
			}
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00095223 File Offset: 0x00093423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashExpAddNotify()
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x0009522C File Offset: 0x0009342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashExpAddNotify(CalabashExpAddNotify other) : this()
		{
			this.curExp_ = other.curExp_;
			this.addExp_ = other.addExp_;
			this.curLevel_ = other.curLevel_;
			this.calabashCfg_ = ((other.calabashCfg_ != null) ? other.calabashCfg_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00095290 File Offset: 0x00093490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashExpAddNotify Clone()
		{
			return new CalabashExpAddNotify(this);
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x00095298 File Offset: 0x00093498
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x000952A0 File Offset: 0x000934A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x000952A9 File Offset: 0x000934A9
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x000952B1 File Offset: 0x000934B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddExp
		{
			get
			{
				return this.addExp_;
			}
			set
			{
				this.addExp_ = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x000952BA File Offset: 0x000934BA
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x000952C2 File Offset: 0x000934C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLevel
		{
			get
			{
				return this.curLevel_;
			}
			set
			{
				this.curLevel_ = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x000952CB File Offset: 0x000934CB
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x000952D3 File Offset: 0x000934D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg CalabashCfg
		{
			get
			{
				return this.calabashCfg_;
			}
			set
			{
				this.calabashCfg_ = value;
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x000952DC File Offset: 0x000934DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashExpAddNotify);
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x000952EC File Offset: 0x000934EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashExpAddNotify other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.AddExp == other.AddExp && this.CurLevel == other.CurLevel && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x0009535C File Offset: 0x0009355C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurExp != 0)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this.AddExp != 0)
			{
				num ^= this.AddExp.GetHashCode();
			}
			if (this.CurLevel != 0)
			{
				num ^= this.CurLevel.GetHashCode();
			}
			if (this.calabashCfg_ != null)
			{
				num ^= this.CalabashCfg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000953E3 File Offset: 0x000935E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x000953F0 File Offset: 0x000935F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x000953FC File Offset: 0x000935FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurLevel);
			}
			if (this.AddExp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AddExp);
			}
			if (this.CurExp != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00095490 File Offset: 0x00093690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurExp);
			}
			if (this.AddExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddExp);
			}
			if (this.CurLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLevel);
			}
			if (this.calabashCfg_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CalabashCfg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00095518 File Offset: 0x00093718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashExpAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurExp != 0)
			{
				this.CurExp = other.CurExp;
			}
			if (other.AddExp != 0)
			{
				this.AddExp = other.AddExp;
			}
			if (other.CurLevel != 0)
			{
				this.CurLevel = other.CurLevel;
			}
			if (other.calabashCfg_ != null)
			{
				if (this.calabashCfg_ == null)
				{
					this.CalabashCfg = new CalabashCfg();
				}
				this.CalabashCfg.MergeFrom(other.CalabashCfg);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x000955A8 File Offset: 0x000937A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x000955B4 File Offset: 0x000937B4
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
				if (num <= 48U)
				{
					if (num == 42U)
					{
						if (this.calabashCfg_ == null)
						{
							this.CalabashCfg = new CalabashCfg();
						}
						input.ReadMessage(this.CalabashCfg);
						continue;
					}
					if (num == 48U)
					{
						this.CurLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.AddExp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CurExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C98 RID: 11416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C99 RID: 11417
		public const int CurExpFieldNumber = 14;

		// Token: 0x04002C9A RID: 11418
		private int curExp_;

		// Token: 0x04002C9B RID: 11419
		public const int AddExpFieldNumber = 13;

		// Token: 0x04002C9C RID: 11420
		private int addExp_;

		// Token: 0x04002C9D RID: 11421
		public const int CurLevelFieldNumber = 6;

		// Token: 0x04002C9E RID: 11422
		private int curLevel_;

		// Token: 0x04002C9F RID: 11423
		public const int CalabashCfgFieldNumber = 5;

		// Token: 0x04002CA0 RID: 11424
		private CalabashCfg calabashCfg_;
	}
}
