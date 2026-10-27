using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB3 RID: 3763
	[NetMessage(EMessageId.RecallMapMarkUpdateNotify)]
	public sealed class RecallMapMarkUpdateNotify : IMessage<RecallMapMarkUpdateNotify>, IMessage, IEquatable<RecallMapMarkUpdateNotify>, IDeepCloneable<RecallMapMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601430F RID: 82703 RVA: 0x002F0001 File Offset: 0x002EE201
		[NullableContext(1)]
		public static RecallMapMarkUpdateNotify Create()
		{
			return new RecallMapMarkUpdateNotify();
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x06014310 RID: 82704 RVA: 0x002F0008 File Offset: 0x002EE208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x06014311 RID: 82705 RVA: 0x002F000B File Offset: 0x002EE20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallMapMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014312 RID: 82706 RVA: 0x002F0012 File Offset: 0x002EE212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify()
		{
		}

		// Token: 0x06014313 RID: 82707 RVA: 0x002F001A File Offset: 0x002EE21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify(RecallMapMarkUpdateNotify other) : this()
		{
			this.markInfo_ = ((other.markInfo_ != null) ? other.markInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014314 RID: 82708 RVA: 0x002F004F File Offset: 0x002EE24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify Clone()
		{
			return new RecallMapMarkUpdateNotify(this);
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x06014315 RID: 82709 RVA: 0x002F0057 File Offset: 0x002EE257
		// (set) Token: 0x06014316 RID: 82710 RVA: 0x002F005F File Offset: 0x002EE25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo MarkInfo
		{
			get
			{
				return this.markInfo_;
			}
			set
			{
				this.markInfo_ = value;
			}
		}

		// Token: 0x06014317 RID: 82711 RVA: 0x002F0068 File Offset: 0x002EE268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallMapMarkUpdateNotify);
		}

		// Token: 0x06014318 RID: 82712 RVA: 0x002F0076 File Offset: 0x002EE276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallMapMarkUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MarkInfo, other.MarkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014319 RID: 82713 RVA: 0x002F00AC File Offset: 0x002EE2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.markInfo_ != null)
			{
				num ^= this.MarkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601431A RID: 82714 RVA: 0x002F00E8 File Offset: 0x002EE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601431B RID: 82715 RVA: 0x002F00F5 File Offset: 0x002EE2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601431C RID: 82716 RVA: 0x002F00FE File Offset: 0x002EE2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.markInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MarkInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601431D RID: 82717 RVA: 0x002F0130 File Offset: 0x002EE330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.markInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MarkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601431E RID: 82718 RVA: 0x002F0170 File Offset: 0x002EE370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallMapMarkUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.markInfo_ != null)
			{
				if (this.markInfo_ == null)
				{
					this.MarkInfo = new MapMarkShowInfo();
				}
				this.MarkInfo.MergeFrom(other.MarkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601431F RID: 82719 RVA: 0x002F01C4 File Offset: 0x002EE3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014320 RID: 82720 RVA: 0x002F01D0 File Offset: 0x002EE3D0
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.markInfo_ == null)
					{
						this.MarkInfo = new MapMarkShowInfo();
					}
					input.ReadMessage(this.MarkInfo);
				}
			}
		}

		// Token: 0x04007AEE RID: 31470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AEF RID: 31471
		public const int MarkInfoFieldNumber = 12;

		// Token: 0x04007AF0 RID: 31472
		private MapMarkShowInfo markInfo_;
	}
}
