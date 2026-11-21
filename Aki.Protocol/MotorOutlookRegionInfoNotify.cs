using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7F RID: 2687
	[NetMessage(EMessageId.MotorOutlookRegionInfoNotify)]
	public sealed class MotorOutlookRegionInfoNotify : IMessage<MotorOutlookRegionInfoNotify>, IMessage, IEquatable<MotorOutlookRegionInfoNotify>, IDeepCloneable<MotorOutlookRegionInfoNotify>, IBufferMessage
	{
		// Token: 0x0600EA68 RID: 60008 RVA: 0x00223F66 File Offset: 0x00222166
		[NullableContext(1)]
		public static MotorOutlookRegionInfoNotify Create()
		{
			return new MotorOutlookRegionInfoNotify();
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x00223F6D File Offset: 0x0022216D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x00223F70 File Offset: 0x00222170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookRegionInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x00223F77 File Offset: 0x00222177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify()
		{
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x00223F7F File Offset: 0x0022217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify(MotorOutlookRegionInfoNotify other) : this()
		{
			this.motorOutlookRegion_ = ((other.motorOutlookRegion_ != null) ? other.motorOutlookRegion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x00223FB4 File Offset: 0x002221B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify Clone()
		{
			return new MotorOutlookRegionInfoNotify(this);
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x00223FBC File Offset: 0x002221BC
		// (set) Token: 0x0600EA6F RID: 60015 RVA: 0x00223FC4 File Offset: 0x002221C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb MotorOutlookRegion
		{
			get
			{
				return this.motorOutlookRegion_;
			}
			set
			{
				this.motorOutlookRegion_ = value;
			}
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x00223FCD File Offset: 0x002221CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookRegionInfoNotify);
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x00223FDB File Offset: 0x002221DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookRegionInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookRegion, other.MotorOutlookRegion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA72 RID: 60018 RVA: 0x00224010 File Offset: 0x00222210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookRegion_ != null)
			{
				num ^= this.MotorOutlookRegion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x0022404C File Offset: 0x0022224C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x00224059 File Offset: 0x00222259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x00224062 File Offset: 0x00222262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookRegion_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MotorOutlookRegion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x00224094 File Offset: 0x00222294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookRegion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookRegion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x002240D4 File Offset: 0x002222D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookRegionInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookRegion_ != null)
			{
				if (this.motorOutlookRegion_ == null)
				{
					this.MotorOutlookRegion = new MotorOutlookRegionPb();
				}
				this.MotorOutlookRegion.MergeFrom(other.MotorOutlookRegion);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x00224128 File Offset: 0x00222328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x00224134 File Offset: 0x00222334
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.motorOutlookRegion_ == null)
					{
						this.MotorOutlookRegion = new MotorOutlookRegionPb();
					}
					input.ReadMessage(this.MotorOutlookRegion);
				}
			}
		}

		// Token: 0x04005F93 RID: 24467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F94 RID: 24468
		public const int MotorOutlookRegionFieldNumber = 5;

		// Token: 0x04005F95 RID: 24469
		private MotorOutlookRegionPb motorOutlookRegion_;
	}
}
