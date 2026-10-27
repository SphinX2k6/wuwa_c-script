using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150D RID: 5389
	[NetMessage(EMessageId.WeeklyFrameworkInfoUpdateNotify)]
	public sealed class WeeklyFrameworkInfoUpdateNotify : IMessage<WeeklyFrameworkInfoUpdateNotify>, IMessage, IEquatable<WeeklyFrameworkInfoUpdateNotify>, IDeepCloneable<WeeklyFrameworkInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C7B7 RID: 116663 RVA: 0x0041D1EB File Offset: 0x0041B3EB
		[NullableContext(1)]
		public static WeeklyFrameworkInfoUpdateNotify Create()
		{
			return new WeeklyFrameworkInfoUpdateNotify();
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x0601C7B8 RID: 116664 RVA: 0x0041D1F2 File Offset: 0x0041B3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x0601C7B9 RID: 116665 RVA: 0x0041D1F5 File Offset: 0x0041B3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C7BA RID: 116666 RVA: 0x0041D1FC File Offset: 0x0041B3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify()
		{
		}

		// Token: 0x0601C7BB RID: 116667 RVA: 0x0041D204 File Offset: 0x0041B404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify(WeeklyFrameworkInfoUpdateNotify other) : this()
		{
			this.frameworkInfo_ = ((other.frameworkInfo_ != null) ? other.frameworkInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7BC RID: 116668 RVA: 0x0041D239 File Offset: 0x0041B439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify Clone()
		{
			return new WeeklyFrameworkInfoUpdateNotify(this);
		}

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x0601C7BD RID: 116669 RVA: 0x0041D241 File Offset: 0x0041B441
		// (set) Token: 0x0601C7BE RID: 116670 RVA: 0x0041D249 File Offset: 0x0041B449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo FrameworkInfo
		{
			get
			{
				return this.frameworkInfo_;
			}
			set
			{
				this.frameworkInfo_ = value;
			}
		}

		// Token: 0x0601C7BF RID: 116671 RVA: 0x0041D252 File Offset: 0x0041B452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoUpdateNotify);
		}

		// Token: 0x0601C7C0 RID: 116672 RVA: 0x0041D260 File Offset: 0x0041B460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FrameworkInfo, other.FrameworkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7C1 RID: 116673 RVA: 0x0041D294 File Offset: 0x0041B494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.frameworkInfo_ != null)
			{
				num ^= this.FrameworkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7C2 RID: 116674 RVA: 0x0041D2D0 File Offset: 0x0041B4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7C3 RID: 116675 RVA: 0x0041D2DD File Offset: 0x0041B4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7C4 RID: 116676 RVA: 0x0041D2E6 File Offset: 0x0041B4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.frameworkInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7C5 RID: 116677 RVA: 0x0041D318 File Offset: 0x0041B518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.frameworkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7C6 RID: 116678 RVA: 0x0041D358 File Offset: 0x0041B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.frameworkInfo_ != null)
			{
				if (this.frameworkInfo_ == null)
				{
					this.FrameworkInfo = new WeeklyFrameworkInfo();
				}
				this.FrameworkInfo.MergeFrom(other.FrameworkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7C7 RID: 116679 RVA: 0x0041D3AC File Offset: 0x0041B5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7C8 RID: 116680 RVA: 0x0041D3B8 File Offset: 0x0041B5B8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.frameworkInfo_ == null)
					{
						this.FrameworkInfo = new WeeklyFrameworkInfo();
					}
					input.ReadMessage(this.FrameworkInfo);
				}
			}
		}

		// Token: 0x0400A305 RID: 41733
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A306 RID: 41734
		public const int FrameworkInfoFieldNumber = 8;

		// Token: 0x0400A307 RID: 41735
		private WeeklyFrameworkInfo frameworkInfo_;
	}
}
