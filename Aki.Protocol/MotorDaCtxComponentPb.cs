using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A28 RID: 2600
	public sealed class MotorDaCtxComponentPb : IMessage<MotorDaCtxComponentPb>, IMessage, IEquatable<MotorDaCtxComponentPb>, IDeepCloneable<MotorDaCtxComponentPb>, IBufferMessage
	{
		// Token: 0x0600E33E RID: 58174 RVA: 0x002142B4 File Offset: 0x002124B4
		[NullableContext(1)]
		public static MotorDaCtxComponentPb Create()
		{
			return new MotorDaCtxComponentPb();
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x002142BB File Offset: 0x002124BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600E340 RID: 58176 RVA: 0x002142BE File Offset: 0x002124BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDaCtxComponentPb.Descriptor;
			}
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x002142C5 File Offset: 0x002124C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb()
		{
		}

		// Token: 0x0600E342 RID: 58178 RVA: 0x002142CD File Offset: 0x002124CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb(MotorDaCtxComponentPb other) : this()
		{
			this.motorDaCtxId_ = other.motorDaCtxId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E343 RID: 58179 RVA: 0x002142F2 File Offset: 0x002124F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb Clone()
		{
			return new MotorDaCtxComponentPb(this);
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600E344 RID: 58180 RVA: 0x002142FA File Offset: 0x002124FA
		// (set) Token: 0x0600E345 RID: 58181 RVA: 0x00214302 File Offset: 0x00212502
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

		// Token: 0x0600E346 RID: 58182 RVA: 0x0021430B File Offset: 0x0021250B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDaCtxComponentPb);
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x00214319 File Offset: 0x00212519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDaCtxComponentPb other)
		{
			return other != null && (other == this || (this.MotorDaCtxId == other.MotorDaCtxId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x00214348 File Offset: 0x00212548
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

		// Token: 0x0600E349 RID: 58185 RVA: 0x00214387 File Offset: 0x00212587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x00214394 File Offset: 0x00212594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x0021439D File Offset: 0x0021259D
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

		// Token: 0x0600E34C RID: 58188 RVA: 0x002143D0 File Offset: 0x002125D0
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

		// Token: 0x0600E34D RID: 58189 RVA: 0x0021440E File Offset: 0x0021260E
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

		// Token: 0x0600E34E RID: 58190 RVA: 0x0021443F File Offset: 0x0021263F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x00214448 File Offset: 0x00212648
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

		// Token: 0x04005D29 RID: 23849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D2A RID: 23850
		public const int MotorDaCtxIdFieldNumber = 1;

		// Token: 0x04005D2B RID: 23851
		private long motorDaCtxId_;
	}
}
