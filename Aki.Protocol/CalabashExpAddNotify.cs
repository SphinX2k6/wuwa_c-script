using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021D RID: 541
	[NetMessage(EMessageId.CalabashExpAddNotify)]
	public sealed class CalabashExpAddNotify : IMessage<CalabashExpAddNotify>, IMessage, IEquatable<CalabashExpAddNotify>, IDeepCloneable<CalabashExpAddNotify>, IBufferMessage
	{
		// Token: 0x06003B32 RID: 15154 RVA: 0x000935FA File Offset: 0x000917FA
		[NullableContext(1)]
		public static CalabashExpAddNotify Create()
		{
			return new CalabashExpAddNotify();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x00093601 File Offset: 0x00091801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x00093604 File Offset: 0x00091804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashExpAddNotify.Descriptor;
			}
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x0009360B File Offset: 0x0009180B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashExpAddNotify()
		{
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00093614 File Offset: 0x00091814
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

		// Token: 0x06003B37 RID: 15159 RVA: 0x00093678 File Offset: 0x00091878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashExpAddNotify Clone()
		{
			return new CalabashExpAddNotify(this);
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x00093680 File Offset: 0x00091880
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x00093688 File Offset: 0x00091888
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

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x00093691 File Offset: 0x00091891
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x00093699 File Offset: 0x00091899
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

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x000936A2 File Offset: 0x000918A2
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x000936AA File Offset: 0x000918AA
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x000936B3 File Offset: 0x000918B3
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x000936BB File Offset: 0x000918BB
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

		// Token: 0x06003B40 RID: 15168 RVA: 0x000936C4 File Offset: 0x000918C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashExpAddNotify);
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000936D4 File Offset: 0x000918D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashExpAddNotify other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.AddExp == other.AddExp && this.CurLevel == other.CurLevel && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00093744 File Offset: 0x00091944
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

		// Token: 0x06003B43 RID: 15171 RVA: 0x000937CB File Offset: 0x000919CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x000937D8 File Offset: 0x000919D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x000937E4 File Offset: 0x000919E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AddExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AddExp);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurLevel);
			}
			if (this.CurExp != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurExp);
			}
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00093878 File Offset: 0x00091A78
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

		// Token: 0x06003B47 RID: 15175 RVA: 0x00093900 File Offset: 0x00091B00
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

		// Token: 0x06003B48 RID: 15176 RVA: 0x00093990 File Offset: 0x00091B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x0009399C File Offset: 0x00091B9C
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
					if (num == 24U)
					{
						this.AddExp = input.ReadInt32();
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
					if (num == 56U)
					{
						this.CurExp = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.calabashCfg_ == null)
						{
							this.CalabashCfg = new CalabashCfg();
						}
						input.ReadMessage(this.CalabashCfg);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C16 RID: 11286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C17 RID: 11287
		public const int CurExpFieldNumber = 7;

		// Token: 0x04002C18 RID: 11288
		private int curExp_;

		// Token: 0x04002C19 RID: 11289
		public const int AddExpFieldNumber = 3;

		// Token: 0x04002C1A RID: 11290
		private int addExp_;

		// Token: 0x04002C1B RID: 11291
		public const int CurLevelFieldNumber = 6;

		// Token: 0x04002C1C RID: 11292
		private int curLevel_;

		// Token: 0x04002C1D RID: 11293
		public const int CalabashCfgFieldNumber = 11;

		// Token: 0x04002C1E RID: 11294
		private CalabashCfg calabashCfg_;
	}
}
