using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A70 RID: 2672
	[NetMessage(EMessageId.MotorOutlookDeletePresetRequest)]
	public sealed class MotorOutlookDeletePresetRequest : IMessage<MotorOutlookDeletePresetRequest>, IMessage, IEquatable<MotorOutlookDeletePresetRequest>, IDeepCloneable<MotorOutlookDeletePresetRequest>, IBufferMessage
	{
		// Token: 0x0600E939 RID: 59705 RVA: 0x002213F3 File Offset: 0x0021F5F3
		[NullableContext(1)]
		public static MotorOutlookDeletePresetRequest Create()
		{
			return new MotorOutlookDeletePresetRequest();
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600E93A RID: 59706 RVA: 0x002213FA File Offset: 0x0021F5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600E93B RID: 59707 RVA: 0x002213FD File Offset: 0x0021F5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookDeletePresetRequest.Descriptor;
			}
		}

		// Token: 0x0600E93C RID: 59708 RVA: 0x00221404 File Offset: 0x0021F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest()
		{
		}

		// Token: 0x0600E93D RID: 59709 RVA: 0x0022140C File Offset: 0x0021F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest(MotorOutlookDeletePresetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E93E RID: 59710 RVA: 0x00221431 File Offset: 0x0021F631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest Clone()
		{
			return new MotorOutlookDeletePresetRequest(this);
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600E93F RID: 59711 RVA: 0x00221439 File Offset: 0x0021F639
		// (set) Token: 0x0600E940 RID: 59712 RVA: 0x00221441 File Offset: 0x0021F641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600E941 RID: 59713 RVA: 0x0022144A File Offset: 0x0021F64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookDeletePresetRequest);
		}

		// Token: 0x0600E942 RID: 59714 RVA: 0x00221458 File Offset: 0x0021F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookDeletePresetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E943 RID: 59715 RVA: 0x00221488 File Offset: 0x0021F688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x002214C7 File Offset: 0x0021F6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E945 RID: 59717 RVA: 0x002214D4 File Offset: 0x0021F6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E946 RID: 59718 RVA: 0x002214DD File Offset: 0x0021F6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E947 RID: 59719 RVA: 0x00221510 File Offset: 0x0021F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E948 RID: 59720 RVA: 0x0022154E File Offset: 0x0021F74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookDeletePresetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x0022157F File Offset: 0x0021F77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x00221588 File Offset: 0x0021F788
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F3A RID: 24378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F3B RID: 24379
		public const int IdFieldNumber = 15;

		// Token: 0x04005F3C RID: 24380
		private int id_;
	}
}
