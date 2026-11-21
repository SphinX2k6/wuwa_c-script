using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F7 RID: 4343
	public sealed class RoleTowerTeamUpgradeStepPbData : IMessage<RoleTowerTeamUpgradeStepPbData>, IMessage, IEquatable<RoleTowerTeamUpgradeStepPbData>, IDeepCloneable<RoleTowerTeamUpgradeStepPbData>, IBufferMessage
	{
		// Token: 0x06017384 RID: 95108 RVA: 0x003613ED File Offset: 0x0035F5ED
		[NullableContext(1)]
		public static RoleTowerTeamUpgradeStepPbData Create()
		{
			return new RoleTowerTeamUpgradeStepPbData();
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06017385 RID: 95109 RVA: 0x003613F4 File Offset: 0x0035F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06017386 RID: 95110 RVA: 0x003613F7 File Offset: 0x0035F5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTeamUpgradeStepPbData.Descriptor;
			}
		}

		// Token: 0x06017387 RID: 95111 RVA: 0x003613FE File Offset: 0x0035F5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTeamUpgradeStepPbData()
		{
		}

		// Token: 0x06017388 RID: 95112 RVA: 0x00361406 File Offset: 0x0035F606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTeamUpgradeStepPbData(RoleTowerTeamUpgradeStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017389 RID: 95113 RVA: 0x0036141F File Offset: 0x0035F61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTeamUpgradeStepPbData Clone()
		{
			return new RoleTowerTeamUpgradeStepPbData(this);
		}

		// Token: 0x0601738A RID: 95114 RVA: 0x00361427 File Offset: 0x0035F627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTeamUpgradeStepPbData);
		}

		// Token: 0x0601738B RID: 95115 RVA: 0x00361435 File Offset: 0x0035F635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTeamUpgradeStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601738C RID: 95116 RVA: 0x00361454 File Offset: 0x0035F654
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

		// Token: 0x0601738D RID: 95117 RVA: 0x0036147A File Offset: 0x0035F67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601738E RID: 95118 RVA: 0x00361487 File Offset: 0x0035F687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601738F RID: 95119 RVA: 0x00361490 File Offset: 0x0035F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017390 RID: 95120 RVA: 0x003614A8 File Offset: 0x0035F6A8
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

		// Token: 0x06017391 RID: 95121 RVA: 0x003614CE File Offset: 0x0035F6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTeamUpgradeStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017392 RID: 95122 RVA: 0x003614EB File Offset: 0x0035F6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017393 RID: 95123 RVA: 0x003614F4 File Offset: 0x0035F6F4
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

		// Token: 0x04008AE8 RID: 35560
		private UnknownFieldSet _unknownFields;
	}
}
