using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C6 RID: 1222
	public sealed class EventOption : IMessage<EventOption>, IMessage, IEquatable<EventOption>, IDeepCloneable<EventOption>, IBufferMessage
	{
		// Token: 0x0600747C RID: 29820 RVA: 0x0011D9C3 File Offset: 0x0011BBC3
		[NullableContext(1)]
		public static EventOption Create()
		{
			return new EventOption();
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x0600747D RID: 29821 RVA: 0x0011D9CA File Offset: 0x0011BBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EventOption> Parser
		{
			get
			{
				return EventOption._parser;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x0011D9D1 File Offset: 0x0011BBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x0011D9D4 File Offset: 0x0011BBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventOption.Descriptor;
			}
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x0011D9DB File Offset: 0x0011BBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption()
		{
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x0011D9E4 File Offset: 0x0011BBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption(EventOption other) : this()
		{
			this.configId_ = other.configId_;
			this.mustSelect_ = other.mustSelect_;
			this.condInfo_ = ((other.condInfo_ != null) ? other.condInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x0011DA3C File Offset: 0x0011BC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption Clone()
		{
			return new EventOption(this);
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x0011DA44 File Offset: 0x0011BC44
		// (set) Token: 0x06007484 RID: 29828 RVA: 0x0011DA4C File Offset: 0x0011BC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06007485 RID: 29829 RVA: 0x0011DA55 File Offset: 0x0011BC55
		// (set) Token: 0x06007486 RID: 29830 RVA: 0x0011DA5D File Offset: 0x0011BC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MustSelect
		{
			get
			{
				return this.mustSelect_;
			}
			set
			{
				this.mustSelect_ = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x0011DA66 File Offset: 0x0011BC66
		// (set) Token: 0x06007488 RID: 29832 RVA: 0x0011DA6E File Offset: 0x0011BC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo CondInfo
		{
			get
			{
				return this.condInfo_;
			}
			set
			{
				this.condInfo_ = value;
			}
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x0011DA77 File Offset: 0x0011BC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventOption);
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x0011DA88 File Offset: 0x0011BC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventOption other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.MustSelect == other.MustSelect && object.Equals(this.CondInfo, other.CondInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x0011DAE8 File Offset: 0x0011BCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.MustSelect)
			{
				num ^= this.MustSelect.GetHashCode();
			}
			if (this.condInfo_ != null)
			{
				num ^= this.CondInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x0011DB56 File Offset: 0x0011BD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x0011DB63 File Offset: 0x0011BD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x0011DB6C File Offset: 0x0011BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.MustSelect)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MustSelect);
			}
			if (this.condInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CondInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x0011DBE0 File Offset: 0x0011BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.MustSelect)
			{
				num += 2;
			}
			if (this.condInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CondInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x0011DC44 File Offset: 0x0011BE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EventOption other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.MustSelect)
			{
				this.MustSelect = other.MustSelect;
			}
			if (other.condInfo_ != null)
			{
				if (this.condInfo_ == null)
				{
					this.CondInfo = new CondInfo();
				}
				this.CondInfo.MergeFrom(other.CondInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x0011DCC0 File Offset: 0x0011BEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x0011DCCC File Offset: 0x0011BECC
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.condInfo_ == null)
							{
								this.CondInfo = new CondInfo();
							}
							input.ReadMessage(this.CondInfo);
						}
					}
					else
					{
						this.MustSelect = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DC1 RID: 15809
		private static readonly MessageParser<EventOption> _parser = new MessageParser<EventOption>(() => new EventOption());

		// Token: 0x04003DC2 RID: 15810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DC3 RID: 15811
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04003DC4 RID: 15812
		private int configId_;

		// Token: 0x04003DC5 RID: 15813
		public const int MustSelectFieldNumber = 2;

		// Token: 0x04003DC6 RID: 15814
		private bool mustSelect_;

		// Token: 0x04003DC7 RID: 15815
		public const int CondInfoFieldNumber = 3;

		// Token: 0x04003DC8 RID: 15816
		private CondInfo condInfo_;
	}
}
