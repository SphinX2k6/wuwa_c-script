using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A63 RID: 2659
	[NetMessage(EMessageId.MotorLevelOneKeyRewardRequest)]
	public sealed class MotorLevelOneKeyRewardRequest : IMessage<MotorLevelOneKeyRewardRequest>, IMessage, IEquatable<MotorLevelOneKeyRewardRequest>, IDeepCloneable<MotorLevelOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E835 RID: 59445 RVA: 0x0021F0A2 File Offset: 0x0021D2A2
		[NullableContext(1)]
		public static MotorLevelOneKeyRewardRequest Create()
		{
			return new MotorLevelOneKeyRewardRequest();
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600E836 RID: 59446 RVA: 0x0021F0A9 File Offset: 0x0021D2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600E837 RID: 59447 RVA: 0x0021F0AC File Offset: 0x0021D2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLevelOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E838 RID: 59448 RVA: 0x0021F0B3 File Offset: 0x0021D2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest()
		{
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x0021F0BB File Offset: 0x0021D2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest(MotorLevelOneKeyRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E83A RID: 59450 RVA: 0x0021F0D4 File Offset: 0x0021D2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardRequest Clone()
		{
			return new MotorLevelOneKeyRewardRequest(this);
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x0021F0DC File Offset: 0x0021D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLevelOneKeyRewardRequest);
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x0021F0EA File Offset: 0x0021D2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLevelOneKeyRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E83D RID: 59453 RVA: 0x0021F108 File Offset: 0x0021D308
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

		// Token: 0x0600E83E RID: 59454 RVA: 0x0021F12E File Offset: 0x0021D32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E83F RID: 59455 RVA: 0x0021F13B File Offset: 0x0021D33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E840 RID: 59456 RVA: 0x0021F144 File Offset: 0x0021D344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E841 RID: 59457 RVA: 0x0021F15C File Offset: 0x0021D35C
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

		// Token: 0x0600E842 RID: 59458 RVA: 0x0021F182 File Offset: 0x0021D382
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

		// Token: 0x0600E843 RID: 59459 RVA: 0x0021F19F File Offset: 0x0021D39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E844 RID: 59460 RVA: 0x0021F1A8 File Offset: 0x0021D3A8
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

		// Token: 0x04005EEE RID: 24302
		private UnknownFieldSet _unknownFields;
	}
}
