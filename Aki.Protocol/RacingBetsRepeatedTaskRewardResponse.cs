using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E65 RID: 3685
	[NetMessage(EMessageId.RacingBetsRepeatedTaskRewardResponse)]
	public sealed class RacingBetsRepeatedTaskRewardResponse : IMessage<RacingBetsRepeatedTaskRewardResponse>, IMessage, IEquatable<RacingBetsRepeatedTaskRewardResponse>, IDeepCloneable<RacingBetsRepeatedTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06013D34 RID: 81204 RVA: 0x002E3CA1 File Offset: 0x002E1EA1
		[NullableContext(1)]
		public static RacingBetsRepeatedTaskRewardResponse Create()
		{
			return new RacingBetsRepeatedTaskRewardResponse();
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x06013D35 RID: 81205 RVA: 0x002E3CA8 File Offset: 0x002E1EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x06013D36 RID: 81206 RVA: 0x002E3CAB File Offset: 0x002E1EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRepeatedTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06013D37 RID: 81207 RVA: 0x002E3CB2 File Offset: 0x002E1EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse()
		{
		}

		// Token: 0x06013D38 RID: 81208 RVA: 0x002E3CBA File Offset: 0x002E1EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse(RacingBetsRepeatedTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D39 RID: 81209 RVA: 0x002E3CDF File Offset: 0x002E1EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse Clone()
		{
			return new RacingBetsRepeatedTaskRewardResponse(this);
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x06013D3A RID: 81210 RVA: 0x002E3CE7 File Offset: 0x002E1EE7
		// (set) Token: 0x06013D3B RID: 81211 RVA: 0x002E3CEF File Offset: 0x002E1EEF
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

		// Token: 0x06013D3C RID: 81212 RVA: 0x002E3CF8 File Offset: 0x002E1EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRepeatedTaskRewardResponse);
		}

		// Token: 0x06013D3D RID: 81213 RVA: 0x002E3D06 File Offset: 0x002E1F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRepeatedTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D3E RID: 81214 RVA: 0x002E3D34 File Offset: 0x002E1F34
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

		// Token: 0x06013D3F RID: 81215 RVA: 0x002E3D79 File Offset: 0x002E1F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D40 RID: 81216 RVA: 0x002E3D86 File Offset: 0x002E1F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D41 RID: 81217 RVA: 0x002E3D8F File Offset: 0x002E1F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D42 RID: 81218 RVA: 0x002E3DC4 File Offset: 0x002E1FC4
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

		// Token: 0x06013D43 RID: 81219 RVA: 0x002E3E02 File Offset: 0x002E2002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRepeatedTaskRewardResponse other)
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

		// Token: 0x06013D44 RID: 81220 RVA: 0x002E3E33 File Offset: 0x002E2033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D45 RID: 81221 RVA: 0x002E3E3C File Offset: 0x002E203C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040079BC RID: 31164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079BD RID: 31165
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040079BE RID: 31166
		private ErrorCode errorCode_;
	}
}
