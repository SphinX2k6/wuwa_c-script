using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A74 RID: 2676
	[NetMessage(EMessageId.MotorLevelOneKeyRewardRequest)]
	public sealed class MotorLevelOneKeyRewardRequest : IMessage<MotorLevelOneKeyRewardRequest>, IMessage, IEquatable<MotorLevelOneKeyRewardRequest>, IDeepCloneable<MotorLevelOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E94F RID: 59727 RVA: 0x00221296 File Offset: 0x0021F496
		[NullableContext(1)]
		public static MotorLevelOneKeyRewardRequest Create()
		{
			return new MotorLevelOneKeyRewardRequest();
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600E950 RID: 59728 RVA: 0x0022129D File Offset: 0x0021F49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600E951 RID: 59729 RVA: 0x002212A0 File Offset: 0x0021F4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLevelOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x002212A7 File Offset: 0x0021F4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest()
		{
		}

		// Token: 0x0600E953 RID: 59731 RVA: 0x002212AF File Offset: 0x0021F4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest(MotorLevelOneKeyRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E954 RID: 59732 RVA: 0x002212C8 File Offset: 0x0021F4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest Clone()
		{
			return new MotorLevelOneKeyRewardRequest(this);
		}

		// Token: 0x0600E955 RID: 59733 RVA: 0x002212D0 File Offset: 0x0021F4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLevelOneKeyRewardRequest);
		}

		// Token: 0x0600E956 RID: 59734 RVA: 0x002212DE File Offset: 0x0021F4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLevelOneKeyRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x002212FC File Offset: 0x0021F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E958 RID: 59736 RVA: 0x00221322 File Offset: 0x0021F522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x0022132F File Offset: 0x0021F52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00221338 File Offset: 0x0021F538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00221350 File Offset: 0x0021F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x00221376 File Offset: 0x0021F576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLevelOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x00221393 File Offset: 0x0021F593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x0022139C File Offset: 0x0021F59C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005EE5 RID: 24293
		private UnknownFieldSet _unknownFields;
	}
}
