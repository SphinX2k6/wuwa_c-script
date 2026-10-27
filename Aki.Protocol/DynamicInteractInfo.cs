using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041E RID: 1054
	public sealed class DynamicInteractInfo : IMessage<DynamicInteractInfo>, IMessage, IEquatable<DynamicInteractInfo>, IDeepCloneable<DynamicInteractInfo>, IBufferMessage
	{
		// Token: 0x06006564 RID: 25956 RVA: 0x000F4060 File Offset: 0x000F2260
		[NullableContext(1)]
		public static DynamicInteractInfo Create()
		{
			return new DynamicInteractInfo();
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x000F4067 File Offset: 0x000F2267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DynamicInteractInfo> Parser
		{
			get
			{
				return DynamicInteractInfo._parser;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x000F406E File Offset: 0x000F226E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x000F4071 File Offset: 0x000F2271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicInteractInfo.Descriptor;
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x000F4078 File Offset: 0x000F2278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractInfo()
		{
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x000F4098 File Offset: 0x000F2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractInfo(DynamicInteractInfo other) : this()
		{
			this.optionGuid_ = other.optionGuid_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.text_ = other.text_;
			this.delayRemove_ = other.delayRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x000F40FC File Offset: 0x000F22FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractInfo Clone()
		{
			return new DynamicInteractInfo(this);
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x000F4104 File Offset: 0x000F2304
		// (set) Token: 0x0600656C RID: 25964 RVA: 0x000F410C File Offset: 0x000F230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x000F411F File Offset: 0x000F231F
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x000F4127 File Offset: 0x000F2327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x000F4130 File Offset: 0x000F2330
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x000F4138 File Offset: 0x000F2338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Text
		{
			get
			{
				return this.text_;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x000F414B File Offset: 0x000F234B
		// (set) Token: 0x06006572 RID: 25970 RVA: 0x000F4153 File Offset: 0x000F2353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DelayRemove
		{
			get
			{
				return this.delayRemove_;
			}
			set
			{
				this.delayRemove_ = value;
			}
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x000F415C File Offset: 0x000F235C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicInteractInfo);
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x000F416C File Offset: 0x000F236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicInteractInfo other)
		{
			return other != null && (other == this || (!(this.OptionGuid != other.OptionGuid) && object.Equals(this.GameCtx, other.GameCtx) && !(this.Text != other.Text) && this.DelayRemove == other.DelayRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x000F41E4 File Offset: 0x000F23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.Text.Length != 0)
			{
				num ^= this.Text.GetHashCode();
			}
			if (this.DelayRemove)
			{
				num ^= this.DelayRemove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x000F426F File Offset: 0x000F246F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x000F427C File Offset: 0x000F247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x000F4288 File Offset: 0x000F2488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.OptionGuid);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameCtx);
			}
			if (this.Text.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Text);
			}
			if (this.DelayRemove)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.DelayRemove);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x000F4324 File Offset: 0x000F2524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.Text.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			if (this.DelayRemove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x000F43A8 File Offset: 0x000F25A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicInteractInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.Text.Length != 0)
			{
				this.Text = other.Text;
			}
			if (other.DelayRemove)
			{
				this.DelayRemove = other.DelayRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x000F4442 File Offset: 0x000F2642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x000F444C File Offset: 0x000F264C
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.OptionGuid = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.Text = input.ReadString();
						continue;
					}
					if (num == 32U)
					{
						this.DelayRemove = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038D4 RID: 14548
		private static readonly MessageParser<DynamicInteractInfo> _parser = new MessageParser<DynamicInteractInfo>(() => new DynamicInteractInfo());

		// Token: 0x040038D5 RID: 14549
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038D6 RID: 14550
		public const int OptionGuidFieldNumber = 1;

		// Token: 0x040038D7 RID: 14551
		private string optionGuid_ = "";

		// Token: 0x040038D8 RID: 14552
		public const int GameCtxFieldNumber = 2;

		// Token: 0x040038D9 RID: 14553
		private GameCtxPb gameCtx_;

		// Token: 0x040038DA RID: 14554
		public const int TextFieldNumber = 3;

		// Token: 0x040038DB RID: 14555
		private string text_ = "";

		// Token: 0x040038DC RID: 14556
		public const int DelayRemoveFieldNumber = 4;

		// Token: 0x040038DD RID: 14557
		private bool delayRemove_;
	}
}
