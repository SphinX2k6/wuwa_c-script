using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C2 RID: 2498
	[NetMessage(EMessageId.MatchTeamStateNotify)]
	public sealed class MatchTeamStateNotify : IMessage<MatchTeamStateNotify>, IMessage, IEquatable<MatchTeamStateNotify>, IDeepCloneable<MatchTeamStateNotify>, IBufferMessage
	{
		// Token: 0x0600DB33 RID: 56115 RVA: 0x00203250 File Offset: 0x00201450
		[NullableContext(1)]
		public static MatchTeamStateNotify Create()
		{
			return new MatchTeamStateNotify();
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600DB34 RID: 56116 RVA: 0x00203257 File Offset: 0x00201457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600DB35 RID: 56117 RVA: 0x0020325A File Offset: 0x0020145A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamStateNotify.Descriptor;
			}
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00203261 File Offset: 0x00201461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify()
		{
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x00203269 File Offset: 0x00201469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify(MatchTeamStateNotify other) : this()
		{
			this.teamState_ = other.teamState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x0020328E File Offset: 0x0020148E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify Clone()
		{
			return new MatchTeamStateNotify(this);
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600DB39 RID: 56121 RVA: 0x00203296 File Offset: 0x00201496
		// (set) Token: 0x0600DB3A RID: 56122 RVA: 0x0020329E File Offset: 0x0020149E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamState TeamState
		{
			get
			{
				return this.teamState_;
			}
			set
			{
				this.teamState_ = value;
			}
		}

		// Token: 0x0600DB3B RID: 56123 RVA: 0x002032A7 File Offset: 0x002014A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamStateNotify);
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x002032B5 File Offset: 0x002014B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamStateNotify other)
		{
			return other != null && (other == this || (this.TeamState == other.TeamState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x002032E4 File Offset: 0x002014E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num ^= this.TeamState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00203329 File Offset: 0x00201529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x00203336 File Offset: 0x00201536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB40 RID: 56128 RVA: 0x0020333F File Offset: 0x0020153F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.TeamState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB41 RID: 56129 RVA: 0x00203374 File Offset: 0x00201574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeamState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB42 RID: 56130 RVA: 0x002033B2 File Offset: 0x002015B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchTeamStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeamState != MatchTeamState.WaiteConfirm)
			{
				this.TeamState = other.TeamState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x002033E3 File Offset: 0x002015E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x002033EC File Offset: 0x002015EC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TeamState = (MatchTeamState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B01 RID: 23297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B02 RID: 23298
		public const int TeamStateFieldNumber = 3;

		// Token: 0x04005B03 RID: 23299
		private MatchTeamState teamState_;
	}
}
