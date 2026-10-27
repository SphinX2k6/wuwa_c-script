using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A90 RID: 2704
	[NetMessage(EMessageId.MotorOutlookRegionInfoNotify)]
	public sealed class MotorOutlookRegionInfoNotify : IMessage<MotorOutlookRegionInfoNotify>, IMessage, IEquatable<MotorOutlookRegionInfoNotify>, IDeepCloneable<MotorOutlookRegionInfoNotify>, IBufferMessage
	{
		// Token: 0x0600EB82 RID: 60290 RVA: 0x00226162 File Offset: 0x00224362
		[NullableContext(1)]
		public static MotorOutlookRegionInfoNotify Create()
		{
			return new MotorOutlookRegionInfoNotify();
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600EB83 RID: 60291 RVA: 0x00226169 File Offset: 0x00224369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600EB84 RID: 60292 RVA: 0x0022616C File Offset: 0x0022436C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookRegionInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x00226173 File Offset: 0x00224373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify()
		{
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x0022617B File Offset: 0x0022437B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify(MotorOutlookRegionInfoNotify other) : this()
		{
			this.motorOutlookRegion_ = ((other.motorOutlookRegion_ != null) ? other.motorOutlookRegion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x002261B0 File Offset: 0x002243B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionInfoNotify Clone()
		{
			return new MotorOutlookRegionInfoNotify(this);
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600EB88 RID: 60296 RVA: 0x002261B8 File Offset: 0x002243B8
		// (set) Token: 0x0600EB89 RID: 60297 RVA: 0x002261C0 File Offset: 0x002243C0
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

		// Token: 0x0600EB8A RID: 60298 RVA: 0x002261C9 File Offset: 0x002243C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookRegionInfoNotify);
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x002261D7 File Offset: 0x002243D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookRegionInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookRegion, other.MotorOutlookRegion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x0022620C File Offset: 0x0022440C
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

		// Token: 0x0600EB8D RID: 60301 RVA: 0x00226248 File Offset: 0x00224448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x00226255 File Offset: 0x00224455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x0022625E File Offset: 0x0022445E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookRegion_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MotorOutlookRegion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x00226290 File Offset: 0x00224490
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

		// Token: 0x0600EB91 RID: 60305 RVA: 0x002262D0 File Offset: 0x002244D0
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

		// Token: 0x0600EB92 RID: 60306 RVA: 0x00226324 File Offset: 0x00224524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x00226330 File Offset: 0x00224530
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
					if (this.motorOutlookRegion_ == null)
					{
						this.MotorOutlookRegion = new MotorOutlookRegionPb();
					}
					input.ReadMessage(this.MotorOutlookRegion);
				}
			}
		}

		// Token: 0x04005F8A RID: 24458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F8B RID: 24459
		public const int MotorOutlookRegionFieldNumber = 1;

		// Token: 0x04005F8C RID: 24460
		private MotorOutlookRegionPb motorOutlookRegion_;
	}
}
