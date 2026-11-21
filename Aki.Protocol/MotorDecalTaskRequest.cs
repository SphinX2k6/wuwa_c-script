using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1C RID: 2588
	[NetMessage(EMessageId.MotorDecalTaskRequest)]
	public sealed class MotorDecalTaskRequest : IMessage<MotorDecalTaskRequest>, IMessage, IEquatable<MotorDecalTaskRequest>, IDeepCloneable<MotorDecalTaskRequest>, IBufferMessage
	{
		// Token: 0x0600E280 RID: 57984 RVA: 0x00212B14 File Offset: 0x00210D14
		[NullableContext(1)]
		public static MotorDecalTaskRequest Create()
		{
			return new MotorDecalTaskRequest();
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600E281 RID: 57985 RVA: 0x00212B1B File Offset: 0x00210D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x00212B1E File Offset: 0x00210D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600E283 RID: 57987 RVA: 0x00212B25 File Offset: 0x00210D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest()
		{
		}

		// Token: 0x0600E284 RID: 57988 RVA: 0x00212B2D File Offset: 0x00210D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest(MotorDecalTaskRequest other) : this()
		{
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E285 RID: 57989 RVA: 0x00212B52 File Offset: 0x00210D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest Clone()
		{
			return new MotorDecalTaskRequest(this);
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600E286 RID: 57990 RVA: 0x00212B5A File Offset: 0x00210D5A
		// (set) Token: 0x0600E287 RID: 57991 RVA: 0x00212B62 File Offset: 0x00210D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorIp
		{
			get
			{
				return this.motorIp_;
			}
			set
			{
				this.motorIp_ = value;
			}
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x00212B6B File Offset: 0x00210D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalTaskRequest);
		}

		// Token: 0x0600E289 RID: 57993 RVA: 0x00212B79 File Offset: 0x00210D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalTaskRequest other)
		{
			return other != null && (other == this || (this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x00212BA8 File Offset: 0x00210DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorIp != 0)
			{
				num ^= this.MotorIp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x00212BE7 File Offset: 0x00210DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x00212BF4 File Offset: 0x00210DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E28D RID: 57997 RVA: 0x00212BFD File Offset: 0x00210DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x00212C30 File Offset: 0x00210E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorIp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E28F RID: 57999 RVA: 0x00212C6E File Offset: 0x00210E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorIp != 0)
			{
				this.MotorIp = other.MotorIp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E290 RID: 58000 RVA: 0x00212C9F File Offset: 0x00210E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x00212CA8 File Offset: 0x00210EA8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MotorIp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D44 RID: 23876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D45 RID: 23877
		public const int MotorIpFieldNumber = 12;

		// Token: 0x04005D46 RID: 23878
		private int motorIp_;
	}
}
