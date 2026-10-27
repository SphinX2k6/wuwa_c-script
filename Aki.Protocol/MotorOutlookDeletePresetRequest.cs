using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A81 RID: 2689
	[NetMessage(EMessageId.MotorOutlookDeletePresetRequest)]
	public sealed class MotorOutlookDeletePresetRequest : IMessage<MotorOutlookDeletePresetRequest>, IMessage, IEquatable<MotorOutlookDeletePresetRequest>, IDeepCloneable<MotorOutlookDeletePresetRequest>, IBufferMessage
	{
		// Token: 0x0600EA53 RID: 59987 RVA: 0x002235EB File Offset: 0x002217EB
		[NullableContext(1)]
		public static MotorOutlookDeletePresetRequest Create()
		{
			return new MotorOutlookDeletePresetRequest();
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x002235F2 File Offset: 0x002217F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x002235F5 File Offset: 0x002217F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookDeletePresetRequest.Descriptor;
			}
		}

		// Token: 0x0600EA56 RID: 59990 RVA: 0x002235FC File Offset: 0x002217FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest()
		{
		}

		// Token: 0x0600EA57 RID: 59991 RVA: 0x00223604 File Offset: 0x00221804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest(MotorOutlookDeletePresetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x00223629 File Offset: 0x00221829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookDeletePresetRequest Clone()
		{
			return new MotorOutlookDeletePresetRequest(this);
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00223631 File Offset: 0x00221831
		// (set) Token: 0x0600EA5A RID: 59994 RVA: 0x00223639 File Offset: 0x00221839
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

		// Token: 0x0600EA5B RID: 59995 RVA: 0x00223642 File Offset: 0x00221842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookDeletePresetRequest);
		}

		// Token: 0x0600EA5C RID: 59996 RVA: 0x00223650 File Offset: 0x00221850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookDeletePresetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x00223680 File Offset: 0x00221880
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

		// Token: 0x0600EA5E RID: 59998 RVA: 0x002236BF File Offset: 0x002218BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA5F RID: 59999 RVA: 0x002236CC File Offset: 0x002218CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA60 RID: 60000 RVA: 0x002236D5 File Offset: 0x002218D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x00223708 File Offset: 0x00221908
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

		// Token: 0x0600EA62 RID: 60002 RVA: 0x00223746 File Offset: 0x00221946
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

		// Token: 0x0600EA63 RID: 60003 RVA: 0x00223777 File Offset: 0x00221977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x00223780 File Offset: 0x00221980
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F31 RID: 24369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F32 RID: 24370
		public const int IdFieldNumber = 9;

		// Token: 0x04005F33 RID: 24371
		private int id_;
	}
}
