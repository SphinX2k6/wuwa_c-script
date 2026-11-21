using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A76 RID: 2678
	[NetMessage(EMessageId.MotorOutlookFullChangeNotify)]
	public sealed class MotorOutlookFullChangeNotify : IMessage<MotorOutlookFullChangeNotify>, IMessage, IEquatable<MotorOutlookFullChangeNotify>, IDeepCloneable<MotorOutlookFullChangeNotify>, IBufferMessage
	{
		// Token: 0x0600E9B1 RID: 59825 RVA: 0x002224EF File Offset: 0x002206EF
		[NullableContext(1)]
		public static MotorOutlookFullChangeNotify Create()
		{
			return new MotorOutlookFullChangeNotify();
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x002224F6 File Offset: 0x002206F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x002224F9 File Offset: 0x002206F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookFullChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x00222500 File Offset: 0x00220700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify()
		{
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x00222508 File Offset: 0x00220708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify(MotorOutlookFullChangeNotify other) : this()
		{
			this.motorOutlook_ = ((other.motorOutlook_ != null) ? other.motorOutlook_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9B6 RID: 59830 RVA: 0x0022253D File Offset: 0x0022073D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify Clone()
		{
			return new MotorOutlookFullChangeNotify(this);
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600E9B7 RID: 59831 RVA: 0x00222545 File Offset: 0x00220745
		// (set) Token: 0x0600E9B8 RID: 59832 RVA: 0x0022254D File Offset: 0x0022074D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb MotorOutlook
		{
			get
			{
				return this.motorOutlook_;
			}
			set
			{
				this.motorOutlook_ = value;
			}
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x00222556 File Offset: 0x00220756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookFullChangeNotify);
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x00222564 File Offset: 0x00220764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookFullChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlook, other.MotorOutlook) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x00222598 File Offset: 0x00220798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlook_ != null)
			{
				num ^= this.MotorOutlook.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x002225D4 File Offset: 0x002207D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x002225E1 File Offset: 0x002207E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x002225EA File Offset: 0x002207EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlook_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x0022261C File Offset: 0x0022081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlook_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x0022265C File Offset: 0x0022085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookFullChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlook_ != null)
			{
				if (this.motorOutlook_ == null)
				{
					this.MotorOutlook = new MotorOutlookPb();
				}
				this.MotorOutlook.MergeFrom(other.MotorOutlook);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9C1 RID: 59841 RVA: 0x002226B0 File Offset: 0x002208B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9C2 RID: 59842 RVA: 0x002226BC File Offset: 0x002208BC
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
					if (this.motorOutlook_ == null)
					{
						this.MotorOutlook = new MotorOutlookPb();
					}
					input.ReadMessage(this.MotorOutlook);
				}
			}
		}

		// Token: 0x04005F5C RID: 24412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F5D RID: 24413
		public const int MotorOutlookFieldNumber = 12;

		// Token: 0x04005F5E RID: 24414
		private MotorOutlookPb motorOutlook_;
	}
}
