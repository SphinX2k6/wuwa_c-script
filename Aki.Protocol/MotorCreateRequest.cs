using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A23 RID: 2595
	[NetMessage(EMessageId.MotorCreateRequest)]
	public sealed class MotorCreateRequest : IMessage<MotorCreateRequest>, IMessage, IEquatable<MotorCreateRequest>, IDeepCloneable<MotorCreateRequest>, IBufferMessage
	{
		// Token: 0x0600E2E4 RID: 58084 RVA: 0x00213935 File Offset: 0x00211B35
		[NullableContext(1)]
		public static MotorCreateRequest Create()
		{
			return new MotorCreateRequest();
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x0021393C File Offset: 0x00211B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600E2E6 RID: 58086 RVA: 0x0021393F File Offset: 0x00211B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCreateRequest.Descriptor;
			}
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00213946 File Offset: 0x00211B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest()
		{
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x0021394E File Offset: 0x00211B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest(MotorCreateRequest other) : this()
		{
			this.isCreate_ = other.isCreate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00213973 File Offset: 0x00211B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest Clone()
		{
			return new MotorCreateRequest(this);
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600E2EA RID: 58090 RVA: 0x0021397B File Offset: 0x00211B7B
		// (set) Token: 0x0600E2EB RID: 58091 RVA: 0x00213983 File Offset: 0x00211B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCreate
		{
			get
			{
				return this.isCreate_;
			}
			set
			{
				this.isCreate_ = value;
			}
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x0021398C File Offset: 0x00211B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCreateRequest);
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x0021399A File Offset: 0x00211B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCreateRequest other)
		{
			return other != null && (other == this || (this.IsCreate == other.IsCreate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x002139C8 File Offset: 0x00211BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsCreate)
			{
				num ^= this.IsCreate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x00213A07 File Offset: 0x00211C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x00213A14 File Offset: 0x00211C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00213A1D File Offset: 0x00211C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCreate)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsCreate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00213A50 File Offset: 0x00211C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsCreate)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x00213A82 File Offset: 0x00211C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCreateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsCreate)
			{
				this.IsCreate = other.IsCreate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x00213AB3 File Offset: 0x00211CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2F5 RID: 58101 RVA: 0x00213ABC File Offset: 0x00211CBC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsCreate = input.ReadBool();
				}
			}
		}

		// Token: 0x04005D19 RID: 23833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D1A RID: 23834
		public const int IsCreateFieldNumber = 14;

		// Token: 0x04005D1B RID: 23835
		private bool isCreate_;
	}
}
