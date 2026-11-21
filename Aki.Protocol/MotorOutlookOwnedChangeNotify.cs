using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7A RID: 2682
	[NetMessage(EMessageId.MotorOutlookOwnedChangeNotify)]
	public sealed class MotorOutlookOwnedChangeNotify : IMessage<MotorOutlookOwnedChangeNotify>, IMessage, IEquatable<MotorOutlookOwnedChangeNotify>, IDeepCloneable<MotorOutlookOwnedChangeNotify>, IBufferMessage
	{
		// Token: 0x0600E9FD RID: 59901 RVA: 0x00222DFB File Offset: 0x00220FFB
		[NullableContext(1)]
		public static MotorOutlookOwnedChangeNotify Create()
		{
			return new MotorOutlookOwnedChangeNotify();
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600E9FE RID: 59902 RVA: 0x00222E02 File Offset: 0x00221002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600E9FF RID: 59903 RVA: 0x00222E05 File Offset: 0x00221005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookOwnedChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x00222E0C File Offset: 0x0022100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify()
		{
		}

		// Token: 0x0600EA01 RID: 59905 RVA: 0x00222E14 File Offset: 0x00221014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify(MotorOutlookOwnedChangeNotify other) : this()
		{
			this.motorOutlookOwned_ = ((other.motorOutlookOwned_ != null) ? other.motorOutlookOwned_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA02 RID: 59906 RVA: 0x00222E49 File Offset: 0x00221049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedChangeNotify Clone()
		{
			return new MotorOutlookOwnedChangeNotify(this);
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x00222E51 File Offset: 0x00221051
		// (set) Token: 0x0600EA04 RID: 59908 RVA: 0x00222E59 File Offset: 0x00221059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb MotorOutlookOwned
		{
			get
			{
				return this.motorOutlookOwned_;
			}
			set
			{
				this.motorOutlookOwned_ = value;
			}
		}

		// Token: 0x0600EA05 RID: 59909 RVA: 0x00222E62 File Offset: 0x00221062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookOwnedChangeNotify);
		}

		// Token: 0x0600EA06 RID: 59910 RVA: 0x00222E70 File Offset: 0x00221070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookOwnedChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookOwned, other.MotorOutlookOwned) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA07 RID: 59911 RVA: 0x00222EA4 File Offset: 0x002210A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookOwned_ != null)
			{
				num ^= this.MotorOutlookOwned.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA08 RID: 59912 RVA: 0x00222EE0 File Offset: 0x002210E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x00222EED File Offset: 0x002210ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x00222EF6 File Offset: 0x002210F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookOwned_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MotorOutlookOwned);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA0B RID: 59915 RVA: 0x00222F28 File Offset: 0x00221128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookOwned_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookOwned);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x00222F68 File Offset: 0x00221168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookOwnedChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookOwned_ != null)
			{
				if (this.motorOutlookOwned_ == null)
				{
					this.MotorOutlookOwned = new MotorOutlookOwnedPb();
				}
				this.MotorOutlookOwned.MergeFrom(other.MotorOutlookOwned);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x00222FBC File Offset: 0x002211BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA0E RID: 59918 RVA: 0x00222FC8 File Offset: 0x002211C8
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
					if (this.motorOutlookOwned_ == null)
					{
						this.MotorOutlookOwned = new MotorOutlookOwnedPb();
					}
					input.ReadMessage(this.MotorOutlookOwned);
				}
			}
		}

		// Token: 0x04005F6B RID: 24427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F6C RID: 24428
		public const int MotorOutlookOwnedFieldNumber = 8;

		// Token: 0x04005F6D RID: 24429
		private MotorOutlookOwnedPb motorOutlookOwned_;
	}
}
