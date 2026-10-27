using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001277 RID: 4727
	public sealed class SpringFestivalCtx : IMessage<SpringFestivalCtx>, IMessage, IEquatable<SpringFestivalCtx>, IDeepCloneable<SpringFestivalCtx>, IBufferMessage
	{
		// Token: 0x060192E8 RID: 103144 RVA: 0x003AA063 File Offset: 0x003A8263
		[NullableContext(1)]
		public static SpringFestivalCtx Create()
		{
			return new SpringFestivalCtx();
		}

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x060192E9 RID: 103145 RVA: 0x003AA06A File Offset: 0x003A826A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x060192EA RID: 103146 RVA: 0x003AA06D File Offset: 0x003A826D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalCtx.Descriptor;
			}
		}

		// Token: 0x060192EB RID: 103147 RVA: 0x003AA074 File Offset: 0x003A8274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx()
		{
		}

		// Token: 0x060192EC RID: 103148 RVA: 0x003AA07C File Offset: 0x003A827C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx(SpringFestivalCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192ED RID: 103149 RVA: 0x003AA0A1 File Offset: 0x003A82A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx Clone()
		{
			return new SpringFestivalCtx(this);
		}

		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x060192EE RID: 103150 RVA: 0x003AA0A9 File Offset: 0x003A82A9
		// (set) Token: 0x060192EF RID: 103151 RVA: 0x003AA0B1 File Offset: 0x003A82B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x060192F0 RID: 103152 RVA: 0x003AA0BA File Offset: 0x003A82BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalCtx);
		}

		// Token: 0x060192F1 RID: 103153 RVA: 0x003AA0C8 File Offset: 0x003A82C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192F2 RID: 103154 RVA: 0x003AA0F8 File Offset: 0x003A82F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192F3 RID: 103155 RVA: 0x003AA137 File Offset: 0x003A8337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192F4 RID: 103156 RVA: 0x003AA144 File Offset: 0x003A8344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192F5 RID: 103157 RVA: 0x003AA14D File Offset: 0x003A834D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192F6 RID: 103158 RVA: 0x003AA180 File Offset: 0x003A8380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192F7 RID: 103159 RVA: 0x003AA1BE File Offset: 0x003A83BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192F8 RID: 103160 RVA: 0x003AA1EF File Offset: 0x003A83EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192F9 RID: 103161 RVA: 0x003AA1F8 File Offset: 0x003A83F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009446 RID: 37958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009447 RID: 37959
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04009448 RID: 37960
		private int activityId_;
	}
}
