using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E6 RID: 4838
	public sealed class SpringFestivalCtx : IMessage<SpringFestivalCtx>, IMessage, IEquatable<SpringFestivalCtx>, IDeepCloneable<SpringFestivalCtx>, IBufferMessage
	{
		// Token: 0x06019D1E RID: 105758 RVA: 0x003C47B7 File Offset: 0x003C29B7
		[NullableContext(1)]
		public static SpringFestivalCtx Create()
		{
			return new SpringFestivalCtx();
		}

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x06019D1F RID: 105759 RVA: 0x003C47BE File Offset: 0x003C29BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x06019D20 RID: 105760 RVA: 0x003C47C1 File Offset: 0x003C29C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalCtx.Descriptor;
			}
		}

		// Token: 0x06019D21 RID: 105761 RVA: 0x003C47C8 File Offset: 0x003C29C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx()
		{
		}

		// Token: 0x06019D22 RID: 105762 RVA: 0x003C47D0 File Offset: 0x003C29D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx(SpringFestivalCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D23 RID: 105763 RVA: 0x003C47F5 File Offset: 0x003C29F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx Clone()
		{
			return new SpringFestivalCtx(this);
		}

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x06019D24 RID: 105764 RVA: 0x003C47FD File Offset: 0x003C29FD
		// (set) Token: 0x06019D25 RID: 105765 RVA: 0x003C4805 File Offset: 0x003C2A05
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

		// Token: 0x06019D26 RID: 105766 RVA: 0x003C480E File Offset: 0x003C2A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalCtx);
		}

		// Token: 0x06019D27 RID: 105767 RVA: 0x003C481C File Offset: 0x003C2A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D28 RID: 105768 RVA: 0x003C484C File Offset: 0x003C2A4C
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

		// Token: 0x06019D29 RID: 105769 RVA: 0x003C488B File Offset: 0x003C2A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D2A RID: 105770 RVA: 0x003C4898 File Offset: 0x003C2A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D2B RID: 105771 RVA: 0x003C48A1 File Offset: 0x003C2AA1
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

		// Token: 0x06019D2C RID: 105772 RVA: 0x003C48D4 File Offset: 0x003C2AD4
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

		// Token: 0x06019D2D RID: 105773 RVA: 0x003C4912 File Offset: 0x003C2B12
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

		// Token: 0x06019D2E RID: 105774 RVA: 0x003C4943 File Offset: 0x003C2B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D2F RID: 105775 RVA: 0x003C494C File Offset: 0x003C2B4C
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

		// Token: 0x04009870 RID: 39024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009871 RID: 39025
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04009872 RID: 39026
		private int activityId_;
	}
}
