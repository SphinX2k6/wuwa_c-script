using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A14 RID: 2580
	[NetMessage(EMessageId.MotorCycleCruiseStatePush)]
	public sealed class MotorCycleCruiseStatePush : IMessage<MotorCycleCruiseStatePush>, IMessage, IEquatable<MotorCycleCruiseStatePush>, IDeepCloneable<MotorCycleCruiseStatePush>, IBufferMessage
	{
		// Token: 0x0600E1EE RID: 57838 RVA: 0x00211AED File Offset: 0x0020FCED
		[NullableContext(1)]
		public static MotorCycleCruiseStatePush Create()
		{
			return new MotorCycleCruiseStatePush();
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600E1EF RID: 57839 RVA: 0x00211AF4 File Offset: 0x0020FCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x00211AF7 File Offset: 0x0020FCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCycleCruiseStatePush.Descriptor;
			}
		}

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x00211AFE File Offset: 0x0020FCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush()
		{
		}

		// Token: 0x0600E1F2 RID: 57842 RVA: 0x00211B06 File Offset: 0x0020FD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush(MotorCycleCruiseStatePush other) : this()
		{
			this.isStart_ = other.isStart_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x00211B2B File Offset: 0x0020FD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush Clone()
		{
			return new MotorCycleCruiseStatePush(this);
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x00211B33 File Offset: 0x0020FD33
		// (set) Token: 0x0600E1F5 RID: 57845 RVA: 0x00211B3B File Offset: 0x0020FD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x0600E1F6 RID: 57846 RVA: 0x00211B44 File Offset: 0x0020FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCycleCruiseStatePush);
		}

		// Token: 0x0600E1F7 RID: 57847 RVA: 0x00211B52 File Offset: 0x0020FD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCycleCruiseStatePush other)
		{
			return other != null && (other == this || (this.IsStart == other.IsStart && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1F8 RID: 57848 RVA: 0x00211B80 File Offset: 0x0020FD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1F9 RID: 57849 RVA: 0x00211BBF File Offset: 0x0020FDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1FA RID: 57850 RVA: 0x00211BCC File Offset: 0x0020FDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1FB RID: 57851 RVA: 0x00211BD5 File Offset: 0x0020FDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsStart)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsStart);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1FC RID: 57852 RVA: 0x00211C08 File Offset: 0x0020FE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStart)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1FD RID: 57853 RVA: 0x00211C3A File Offset: 0x0020FE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCycleCruiseStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1FE RID: 57854 RVA: 0x00211C6B File Offset: 0x0020FE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1FF RID: 57855 RVA: 0x00211C74 File Offset: 0x0020FE74
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
					this.IsStart = input.ReadBool();
				}
			}
		}

		// Token: 0x04005D28 RID: 23848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D29 RID: 23849
		public const int IsStartFieldNumber = 9;

		// Token: 0x04005D2A RID: 23850
		private bool isStart_;
	}
}
