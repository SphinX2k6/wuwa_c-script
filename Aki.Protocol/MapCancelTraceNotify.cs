using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000983 RID: 2435
	[NetMessage(EMessageId.MapCancelTraceNotify)]
	public sealed class MapCancelTraceNotify : IMessage<MapCancelTraceNotify>, IMessage, IEquatable<MapCancelTraceNotify>, IDeepCloneable<MapCancelTraceNotify>, IBufferMessage
	{
		// Token: 0x0600D622 RID: 54818 RVA: 0x001F7EA0 File Offset: 0x001F60A0
		[NullableContext(1)]
		public static MapCancelTraceNotify Create()
		{
			return new MapCancelTraceNotify();
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600D623 RID: 54819 RVA: 0x001F7EA7 File Offset: 0x001F60A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600D624 RID: 54820 RVA: 0x001F7EAA File Offset: 0x001F60AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceNotify.Descriptor;
			}
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x001F7EB1 File Offset: 0x001F60B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify()
		{
		}

		// Token: 0x0600D626 RID: 54822 RVA: 0x001F7EB9 File Offset: 0x001F60B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify(MapCancelTraceNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x001F7EDE File Offset: 0x001F60DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceNotify Clone()
		{
			return new MapCancelTraceNotify(this);
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600D628 RID: 54824 RVA: 0x001F7EE6 File Offset: 0x001F60E6
		// (set) Token: 0x0600D629 RID: 54825 RVA: 0x001F7EEE File Offset: 0x001F60EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x001F7EF7 File Offset: 0x001F60F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceNotify);
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x001F7F05 File Offset: 0x001F6105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x001F7F34 File Offset: 0x001F6134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x001F7F73 File Offset: 0x001F6173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x001F7F80 File Offset: 0x001F6180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x001F7F89 File Offset: 0x001F6189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x001F7FBC File Offset: 0x001F61BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x001F7FFA File Offset: 0x001F61FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCancelTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D632 RID: 54834 RVA: 0x001F802B File Offset: 0x001F622B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x001F8034 File Offset: 0x001F6234
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400598A RID: 22922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400598B RID: 22923
		public const int MarkIdFieldNumber = 9;

		// Token: 0x0400598C RID: 22924
		private int markId_;
	}
}
