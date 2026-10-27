using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DD RID: 1245
	public sealed class EventOption : IMessage<EventOption>, IMessage, IEquatable<EventOption>, IDeepCloneable<EventOption>, IBufferMessage
	{
		// Token: 0x0600760C RID: 30220 RVA: 0x00120ADB File Offset: 0x0011ECDB
		[NullableContext(1)]
		public static EventOption Create()
		{
			return new EventOption();
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x00120AE2 File Offset: 0x0011ECE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EventOption> Parser
		{
			get
			{
				return EventOption._parser;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x0600760E RID: 30222 RVA: 0x00120AE9 File Offset: 0x0011ECE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x0600760F RID: 30223 RVA: 0x00120AEC File Offset: 0x0011ECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventOption.Descriptor;
			}
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00120AF3 File Offset: 0x0011ECF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption()
		{
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00120AFC File Offset: 0x0011ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption(EventOption other) : this()
		{
			this.configId_ = other.configId_;
			this.mustSelect_ = other.mustSelect_;
			this.condInfo_ = ((other.condInfo_ != null) ? other.condInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00120B54 File Offset: 0x0011ED54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventOption Clone()
		{
			return new EventOption(this);
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06007613 RID: 30227 RVA: 0x00120B5C File Offset: 0x0011ED5C
		// (set) Token: 0x06007614 RID: 30228 RVA: 0x00120B64 File Offset: 0x0011ED64
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

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06007615 RID: 30229 RVA: 0x00120B6D File Offset: 0x0011ED6D
		// (set) Token: 0x06007616 RID: 30230 RVA: 0x00120B75 File Offset: 0x0011ED75
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06007617 RID: 30231 RVA: 0x00120B7E File Offset: 0x0011ED7E
		// (set) Token: 0x06007618 RID: 30232 RVA: 0x00120B86 File Offset: 0x0011ED86
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

		// Token: 0x06007619 RID: 30233 RVA: 0x00120B8F File Offset: 0x0011ED8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventOption);
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00120BA0 File Offset: 0x0011EDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventOption other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.MustSelect == other.MustSelect && object.Equals(this.CondInfo, other.CondInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00120C00 File Offset: 0x0011EE00
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

		// Token: 0x0600761C RID: 30236 RVA: 0x00120C6E File Offset: 0x0011EE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00120C7B File Offset: 0x0011EE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00120C84 File Offset: 0x0011EE84
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

		// Token: 0x0600761F RID: 30239 RVA: 0x00120CF8 File Offset: 0x0011EEF8
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

		// Token: 0x06007620 RID: 30240 RVA: 0x00120D5C File Offset: 0x0011EF5C
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

		// Token: 0x06007621 RID: 30241 RVA: 0x00120DD8 File Offset: 0x0011EFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00120DE4 File Offset: 0x0011EFE4
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

		// Token: 0x04003DD5 RID: 15829
		private static readonly MessageParser<EventOption> _parser = new MessageParser<EventOption>(() => new EventOption());

		// Token: 0x04003DD6 RID: 15830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DD7 RID: 15831
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04003DD8 RID: 15832
		private int configId_;

		// Token: 0x04003DD9 RID: 15833
		public const int MustSelectFieldNumber = 2;

		// Token: 0x04003DDA RID: 15834
		private bool mustSelect_;

		// Token: 0x04003DDB RID: 15835
		public const int CondInfoFieldNumber = 3;

		// Token: 0x04003DDC RID: 15836
		private CondInfo condInfo_;
	}
}
