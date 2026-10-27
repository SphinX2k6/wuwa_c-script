using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001179 RID: 4473
	public sealed class SceneItemStopInfo : IMessage<SceneItemStopInfo>, IMessage, IEquatable<SceneItemStopInfo>, IDeepCloneable<SceneItemStopInfo>, IBufferMessage
	{
		// Token: 0x06017D7D RID: 97661 RVA: 0x0037686D File Offset: 0x00374A6D
		[NullableContext(1)]
		public static SceneItemStopInfo Create()
		{
			return new SceneItemStopInfo();
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06017D7E RID: 97662 RVA: 0x00376874 File Offset: 0x00374A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneItemStopInfo> Parser
		{
			get
			{
				return SceneItemStopInfo._parser;
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06017D7F RID: 97663 RVA: 0x0037687B File Offset: 0x00374A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06017D80 RID: 97664 RVA: 0x0037687E File Offset: 0x00374A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopInfo.Descriptor;
			}
		}

		// Token: 0x06017D81 RID: 97665 RVA: 0x00376885 File Offset: 0x00374A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo()
		{
		}

		// Token: 0x06017D82 RID: 97666 RVA: 0x00376890 File Offset: 0x00374A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo(SceneItemStopInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D83 RID: 97667 RVA: 0x003768DC File Offset: 0x00374ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo Clone()
		{
			return new SceneItemStopInfo(this);
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06017D84 RID: 97668 RVA: 0x003768E4 File Offset: 0x00374AE4
		// (set) Token: 0x06017D85 RID: 97669 RVA: 0x003768EC File Offset: 0x00374AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x06017D86 RID: 97670 RVA: 0x003768F5 File Offset: 0x00374AF5
		// (set) Token: 0x06017D87 RID: 97671 RVA: 0x003768FD File Offset: 0x00374AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06017D88 RID: 97672 RVA: 0x00376906 File Offset: 0x00374B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopInfo);
		}

		// Token: 0x06017D89 RID: 97673 RVA: 0x00376914 File Offset: 0x00374B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D8A RID: 97674 RVA: 0x00376964 File Offset: 0x00374B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D8B RID: 97675 RVA: 0x003769B9 File Offset: 0x00374BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D8C RID: 97676 RVA: 0x003769C6 File Offset: 0x00374BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D8D RID: 97677 RVA: 0x003769D0 File Offset: 0x00374BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D8E RID: 97678 RVA: 0x00376A28 File Offset: 0x00374C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D8F RID: 97679 RVA: 0x00376A80 File Offset: 0x00374C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D90 RID: 97680 RVA: 0x00376AE8 File Offset: 0x00374CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D91 RID: 97681 RVA: 0x00376AF4 File Offset: 0x00374CF4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008D58 RID: 36184
		private static readonly MessageParser<SceneItemStopInfo> _parser = new MessageParser<SceneItemStopInfo>(() => new SceneItemStopInfo());

		// Token: 0x04008D59 RID: 36185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D5A RID: 36186
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008D5B RID: 36187
		private long entityId_;

		// Token: 0x04008D5C RID: 36188
		public const int LocationFieldNumber = 2;

		// Token: 0x04008D5D RID: 36189
		private Vector location_;
	}
}
