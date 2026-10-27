using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134A RID: 4938
	[NetMessage(EMessageId.TemporaryTeleportChangeNotify)]
	public sealed class TemporaryTeleportChangeNotify : IMessage<TemporaryTeleportChangeNotify>, IMessage, IEquatable<TemporaryTeleportChangeNotify>, IDeepCloneable<TemporaryTeleportChangeNotify>, IBufferMessage
	{
		// Token: 0x0601A3C0 RID: 107456 RVA: 0x003CF9A5 File Offset: 0x003CDBA5
		[NullableContext(1)]
		public static TemporaryTeleportChangeNotify Create()
		{
			return new TemporaryTeleportChangeNotify();
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x0601A3C1 RID: 107457 RVA: 0x003CF9AC File Offset: 0x003CDBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x0601A3C2 RID: 107458 RVA: 0x003CF9AF File Offset: 0x003CDBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601A3C3 RID: 107459 RVA: 0x003CF9B6 File Offset: 0x003CDBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify()
		{
		}

		// Token: 0x0601A3C4 RID: 107460 RVA: 0x003CF9BE File Offset: 0x003CDBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify(TemporaryTeleportChangeNotify other) : this()
		{
			this.temporaryTeleportInfo_ = ((other.temporaryTeleportInfo_ != null) ? other.temporaryTeleportInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3C5 RID: 107461 RVA: 0x003CF9F3 File Offset: 0x003CDBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify Clone()
		{
			return new TemporaryTeleportChangeNotify(this);
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x0601A3C6 RID: 107462 RVA: 0x003CF9FB File Offset: 0x003CDBFB
		// (set) Token: 0x0601A3C7 RID: 107463 RVA: 0x003CFA03 File Offset: 0x003CDC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo TemporaryTeleportInfo
		{
			get
			{
				return this.temporaryTeleportInfo_;
			}
			set
			{
				this.temporaryTeleportInfo_ = value;
			}
		}

		// Token: 0x0601A3C8 RID: 107464 RVA: 0x003CFA0C File Offset: 0x003CDC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportChangeNotify);
		}

		// Token: 0x0601A3C9 RID: 107465 RVA: 0x003CFA1A File Offset: 0x003CDC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TemporaryTeleportInfo, other.TemporaryTeleportInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3CA RID: 107466 RVA: 0x003CFA50 File Offset: 0x003CDC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.temporaryTeleportInfo_ != null)
			{
				num ^= this.TemporaryTeleportInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3CB RID: 107467 RVA: 0x003CFA8C File Offset: 0x003CDC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3CC RID: 107468 RVA: 0x003CFA99 File Offset: 0x003CDC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3CD RID: 107469 RVA: 0x003CFAA2 File Offset: 0x003CDCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.temporaryTeleportInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3CE RID: 107470 RVA: 0x003CFAD4 File Offset: 0x003CDCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.temporaryTeleportInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A3CF RID: 107471 RVA: 0x003CFB14 File Offset: 0x003CDD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.temporaryTeleportInfo_ != null)
			{
				if (this.temporaryTeleportInfo_ == null)
				{
					this.TemporaryTeleportInfo = new TemporaryTeleportInfo();
				}
				this.TemporaryTeleportInfo.MergeFrom(other.TemporaryTeleportInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3D0 RID: 107472 RVA: 0x003CFB68 File Offset: 0x003CDD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3D1 RID: 107473 RVA: 0x003CFB74 File Offset: 0x003CDD74
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
					if (this.temporaryTeleportInfo_ == null)
					{
						this.TemporaryTeleportInfo = new TemporaryTeleportInfo();
					}
					input.ReadMessage(this.TemporaryTeleportInfo);
				}
			}
		}

		// Token: 0x0400990A RID: 39178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400990B RID: 39179
		public const int TemporaryTeleportInfoFieldNumber = 1;

		// Token: 0x0400990C RID: 39180
		private TemporaryTeleportInfo temporaryTeleportInfo_;
	}
}
