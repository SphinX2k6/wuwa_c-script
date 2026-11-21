using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000407 RID: 1031
	public sealed class DynamicInteractInfo : IMessage<DynamicInteractInfo>, IMessage, IEquatable<DynamicInteractInfo>, IDeepCloneable<DynamicInteractInfo>, IBufferMessage
	{
		// Token: 0x060063D4 RID: 25556 RVA: 0x000F0EEC File Offset: 0x000EF0EC
		[NullableContext(1)]
		public static DynamicInteractInfo Create()
		{
			return new DynamicInteractInfo();
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x060063D5 RID: 25557 RVA: 0x000F0EF3 File Offset: 0x000EF0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DynamicInteractInfo> Parser
		{
			get
			{
				return DynamicInteractInfo._parser;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x000F0EFA File Offset: 0x000EF0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x000F0EFD File Offset: 0x000EF0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicInteractInfo.Descriptor;
			}
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x000F0F04 File Offset: 0x000EF104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractInfo()
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x000F0F24 File Offset: 0x000EF124
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

		// Token: 0x060063DA RID: 25562 RVA: 0x000F0F88 File Offset: 0x000EF188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractInfo Clone()
		{
			return new DynamicInteractInfo(this);
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060063DB RID: 25563 RVA: 0x000F0F90 File Offset: 0x000EF190
		// (set) Token: 0x060063DC RID: 25564 RVA: 0x000F0F98 File Offset: 0x000EF198
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

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060063DD RID: 25565 RVA: 0x000F0FAB File Offset: 0x000EF1AB
		// (set) Token: 0x060063DE RID: 25566 RVA: 0x000F0FB3 File Offset: 0x000EF1B3
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

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060063DF RID: 25567 RVA: 0x000F0FBC File Offset: 0x000EF1BC
		// (set) Token: 0x060063E0 RID: 25568 RVA: 0x000F0FC4 File Offset: 0x000EF1C4
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

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060063E1 RID: 25569 RVA: 0x000F0FD7 File Offset: 0x000EF1D7
		// (set) Token: 0x060063E2 RID: 25570 RVA: 0x000F0FDF File Offset: 0x000EF1DF
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

		// Token: 0x060063E3 RID: 25571 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicInteractInfo);
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x000F0FF8 File Offset: 0x000EF1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicInteractInfo other)
		{
			return other != null && (other == this || (!(this.OptionGuid != other.OptionGuid) && object.Equals(this.GameCtx, other.GameCtx) && !(this.Text != other.Text) && this.DelayRemove == other.DelayRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x000F1070 File Offset: 0x000EF270
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

		// Token: 0x060063E6 RID: 25574 RVA: 0x000F10FB File Offset: 0x000EF2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x000F1108 File Offset: 0x000EF308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x000F1114 File Offset: 0x000EF314
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

		// Token: 0x060063E9 RID: 25577 RVA: 0x000F11B0 File Offset: 0x000EF3B0
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

		// Token: 0x060063EA RID: 25578 RVA: 0x000F1234 File Offset: 0x000EF434
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

		// Token: 0x060063EB RID: 25579 RVA: 0x000F12CE File Offset: 0x000EF4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x000F12D8 File Offset: 0x000EF4D8
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

		// Token: 0x040038C1 RID: 14529
		private static readonly MessageParser<DynamicInteractInfo> _parser = new MessageParser<DynamicInteractInfo>(() => new DynamicInteractInfo());

		// Token: 0x040038C2 RID: 14530
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038C3 RID: 14531
		public const int OptionGuidFieldNumber = 1;

		// Token: 0x040038C4 RID: 14532
		private string optionGuid_ = "";

		// Token: 0x040038C5 RID: 14533
		public const int GameCtxFieldNumber = 2;

		// Token: 0x040038C6 RID: 14534
		private GameCtxPb gameCtx_;

		// Token: 0x040038C7 RID: 14535
		public const int TextFieldNumber = 3;

		// Token: 0x040038C8 RID: 14536
		private string text_ = "";

		// Token: 0x040038C9 RID: 14537
		public const int DelayRemoveFieldNumber = 4;

		// Token: 0x040038CA RID: 14538
		private bool delayRemove_;
	}
}
