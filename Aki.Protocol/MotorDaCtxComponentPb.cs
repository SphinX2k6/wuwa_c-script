using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A17 RID: 2583
	public sealed class MotorDaCtxComponentPb : IMessage<MotorDaCtxComponentPb>, IMessage, IEquatable<MotorDaCtxComponentPb>, IDeepCloneable<MotorDaCtxComponentPb>, IBufferMessage
	{
		// Token: 0x0600E224 RID: 57892 RVA: 0x002120C0 File Offset: 0x002102C0
		[NullableContext(1)]
		public static MotorDaCtxComponentPb Create()
		{
			return new MotorDaCtxComponentPb();
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600E225 RID: 57893 RVA: 0x002120C7 File Offset: 0x002102C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600E226 RID: 57894 RVA: 0x002120CA File Offset: 0x002102CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDaCtxComponentPb.Descriptor;
			}
		}

		// Token: 0x0600E227 RID: 57895 RVA: 0x002120D1 File Offset: 0x002102D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb()
		{
		}

		// Token: 0x0600E228 RID: 57896 RVA: 0x002120D9 File Offset: 0x002102D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb(MotorDaCtxComponentPb other) : this()
		{
			this.motorDaCtxId_ = other.motorDaCtxId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E229 RID: 57897 RVA: 0x002120FE File Offset: 0x002102FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb Clone()
		{
			return new MotorDaCtxComponentPb(this);
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600E22A RID: 57898 RVA: 0x00212106 File Offset: 0x00210306
		// (set) Token: 0x0600E22B RID: 57899 RVA: 0x0021210E File Offset: 0x0021030E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MotorDaCtxId
		{
			get
			{
				return this.motorDaCtxId_;
			}
			set
			{
				this.motorDaCtxId_ = value;
			}
		}

		// Token: 0x0600E22C RID: 57900 RVA: 0x00212117 File Offset: 0x00210317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDaCtxComponentPb);
		}

		// Token: 0x0600E22D RID: 57901 RVA: 0x00212125 File Offset: 0x00210325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDaCtxComponentPb other)
		{
			return other != null && (other == this || (this.MotorDaCtxId == other.MotorDaCtxId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E22E RID: 57902 RVA: 0x00212154 File Offset: 0x00210354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorDaCtxId != 0L)
			{
				num ^= this.MotorDaCtxId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x00212193 File Offset: 0x00210393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E230 RID: 57904 RVA: 0x002121A0 File Offset: 0x002103A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x002121A9 File Offset: 0x002103A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorDaCtxId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.MotorDaCtxId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E232 RID: 57906 RVA: 0x002121DC File Offset: 0x002103DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorDaCtxId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MotorDaCtxId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E233 RID: 57907 RVA: 0x0021221A File Offset: 0x0021041A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDaCtxComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorDaCtxId != 0L)
			{
				this.MotorDaCtxId = other.MotorDaCtxId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E234 RID: 57908 RVA: 0x0021224B File Offset: 0x0021044B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E235 RID: 57909 RVA: 0x00212254 File Offset: 0x00210454
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MotorDaCtxId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005D32 RID: 23858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D33 RID: 23859
		public const int MotorDaCtxIdFieldNumber = 1;

		// Token: 0x04005D34 RID: 23860
		private long motorDaCtxId_;
	}
}
