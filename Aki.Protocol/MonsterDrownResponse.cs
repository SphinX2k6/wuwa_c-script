using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EC RID: 2540
	[NetMessage(EMessageId.MonsterDrownResponse)]
	public sealed class MonsterDrownResponse : IMessage<MonsterDrownResponse>, IMessage, IEquatable<MonsterDrownResponse>, IDeepCloneable<MonsterDrownResponse>, IBufferMessage
	{
		// Token: 0x0600DEBA RID: 57018 RVA: 0x0020ACD4 File Offset: 0x00208ED4
		[NullableContext(1)]
		public static MonsterDrownResponse Create()
		{
			return new MonsterDrownResponse();
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0600DEBB RID: 57019 RVA: 0x0020ACDB File Offset: 0x00208EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0600DEBC RID: 57020 RVA: 0x0020ACDE File Offset: 0x00208EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownResponse.Descriptor;
			}
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x0020ACE5 File Offset: 0x00208EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse()
		{
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x0020ACED File Offset: 0x00208EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse(MonsterDrownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x0020AD12 File Offset: 0x00208F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse Clone()
		{
			return new MonsterDrownResponse(this);
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600DEC0 RID: 57024 RVA: 0x0020AD1A File Offset: 0x00208F1A
		// (set) Token: 0x0600DEC1 RID: 57025 RVA: 0x0020AD22 File Offset: 0x00208F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x0020AD2B File Offset: 0x00208F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownResponse);
		}

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x0020AD39 File Offset: 0x00208F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x0020AD68 File Offset: 0x00208F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x0020ADAD File Offset: 0x00208FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x0020ADBA File Offset: 0x00208FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x0020ADC3 File Offset: 0x00208FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x0020ADF8 File Offset: 0x00208FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0020AE36 File Offset: 0x00209036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDrownResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x0020AE67 File Offset: 0x00209067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x0020AE70 File Offset: 0x00209070
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005C42 RID: 23618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C43 RID: 23619
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005C44 RID: 23620
		private ErrorCode errorCode_;
	}
}
