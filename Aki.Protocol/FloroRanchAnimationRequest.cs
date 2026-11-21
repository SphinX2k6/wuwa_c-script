using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000593 RID: 1427
	[NetMessage(EMessageId.FloroRanchAnimationRequest)]
	public sealed class FloroRanchAnimationRequest : IMessage<FloroRanchAnimationRequest>, IMessage, IEquatable<FloroRanchAnimationRequest>, IDeepCloneable<FloroRanchAnimationRequest>, IBufferMessage
	{
		// Token: 0x0600847B RID: 33915 RVA: 0x0013F18B File Offset: 0x0013D38B
		[NullableContext(1)]
		public static FloroRanchAnimationRequest Create()
		{
			return new FloroRanchAnimationRequest();
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x0600847C RID: 33916 RVA: 0x0013F192 File Offset: 0x0013D392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600847D RID: 33917 RVA: 0x0013F195 File Offset: 0x0013D395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchAnimationRequest.Descriptor;
			}
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x0013F19C File Offset: 0x0013D39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest()
		{
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x0013F1A4 File Offset: 0x0013D3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest(FloroRanchAnimationRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x0013F1C9 File Offset: 0x0013D3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest Clone()
		{
			return new FloroRanchAnimationRequest(this);
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06008481 RID: 33921 RVA: 0x0013F1D1 File Offset: 0x0013D3D1
		// (set) Token: 0x06008482 RID: 33922 RVA: 0x0013F1D9 File Offset: 0x0013D3D9
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

		// Token: 0x06008483 RID: 33923 RVA: 0x0013F1E2 File Offset: 0x0013D3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchAnimationRequest);
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x0013F1F0 File Offset: 0x0013D3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchAnimationRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x0013F220 File Offset: 0x0013D420
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

		// Token: 0x06008486 RID: 33926 RVA: 0x0013F25F File Offset: 0x0013D45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x0013F26C File Offset: 0x0013D46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x0013F275 File Offset: 0x0013D475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x0013F2A8 File Offset: 0x0013D4A8
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

		// Token: 0x0600848A RID: 33930 RVA: 0x0013F2E6 File Offset: 0x0013D4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchAnimationRequest other)
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

		// Token: 0x0600848B RID: 33931 RVA: 0x0013F317 File Offset: 0x0013D517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x0013F320 File Offset: 0x0013D520
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004217 RID: 16919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004218 RID: 16920
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004219 RID: 16921
		private int activityId_;
	}
}
