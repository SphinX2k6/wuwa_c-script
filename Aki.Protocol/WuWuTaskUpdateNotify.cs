using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152A RID: 5418
	[NetMessage(EMessageId.WuWuTaskUpdateNotify)]
	public sealed class WuWuTaskUpdateNotify : IMessage<WuWuTaskUpdateNotify>, IMessage, IEquatable<WuWuTaskUpdateNotify>, IDeepCloneable<WuWuTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601CA19 RID: 117273 RVA: 0x00422619 File Offset: 0x00420819
		[NullableContext(1)]
		public static WuWuTaskUpdateNotify Create()
		{
			return new WuWuTaskUpdateNotify();
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x0601CA1A RID: 117274 RVA: 0x00422620 File Offset: 0x00420820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x0601CA1B RID: 117275 RVA: 0x00422623 File Offset: 0x00420823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601CA1C RID: 117276 RVA: 0x0042262A File Offset: 0x0042082A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify()
		{
		}

		// Token: 0x0601CA1D RID: 117277 RVA: 0x00422632 File Offset: 0x00420832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify(WuWuTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA1E RID: 117278 RVA: 0x00422667 File Offset: 0x00420867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskUpdateNotify Clone()
		{
			return new WuWuTaskUpdateNotify(this);
		}

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x0601CA1F RID: 117279 RVA: 0x0042266F File Offset: 0x0042086F
		// (set) Token: 0x0601CA20 RID: 117280 RVA: 0x00422677 File Offset: 0x00420877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0601CA21 RID: 117281 RVA: 0x00422680 File Offset: 0x00420880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskUpdateNotify);
		}

		// Token: 0x0601CA22 RID: 117282 RVA: 0x0042268E File Offset: 0x0042088E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA23 RID: 117283 RVA: 0x004226C4 File Offset: 0x004208C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA24 RID: 117284 RVA: 0x00422700 File Offset: 0x00420900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA25 RID: 117285 RVA: 0x0042270D File Offset: 0x0042090D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA26 RID: 117286 RVA: 0x00422716 File Offset: 0x00420916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA27 RID: 117287 RVA: 0x00422748 File Offset: 0x00420948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA28 RID: 117288 RVA: 0x00422788 File Offset: 0x00420988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA29 RID: 117289 RVA: 0x004227DC File Offset: 0x004209DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA2A RID: 117290 RVA: 0x004227E8 File Offset: 0x004209E8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x0400A3B4 RID: 41908
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B5 RID: 41909
		public const int TaskFieldNumber = 1;

		// Token: 0x0400A3B6 RID: 41910
		private ConditionTask task_;
	}
}
