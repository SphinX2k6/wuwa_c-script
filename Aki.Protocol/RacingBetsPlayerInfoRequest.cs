using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5E RID: 3678
	[NetMessage(EMessageId.RacingBetsPlayerInfoRequest)]
	public sealed class RacingBetsPlayerInfoRequest : IMessage<RacingBetsPlayerInfoRequest>, IMessage, IEquatable<RacingBetsPlayerInfoRequest>, IDeepCloneable<RacingBetsPlayerInfoRequest>, IBufferMessage
	{
		// Token: 0x06013CAA RID: 81066 RVA: 0x002E2A57 File Offset: 0x002E0C57
		[NullableContext(1)]
		public static RacingBetsPlayerInfoRequest Create()
		{
			return new RacingBetsPlayerInfoRequest();
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x06013CAB RID: 81067 RVA: 0x002E2A5E File Offset: 0x002E0C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x06013CAC RID: 81068 RVA: 0x002E2A61 File Offset: 0x002E0C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013CAD RID: 81069 RVA: 0x002E2A68 File Offset: 0x002E0C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest()
		{
		}

		// Token: 0x06013CAE RID: 81070 RVA: 0x002E2A70 File Offset: 0x002E0C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest(RacingBetsPlayerInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CAF RID: 81071 RVA: 0x002E2A95 File Offset: 0x002E0C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest Clone()
		{
			return new RacingBetsPlayerInfoRequest(this);
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x06013CB0 RID: 81072 RVA: 0x002E2A9D File Offset: 0x002E0C9D
		// (set) Token: 0x06013CB1 RID: 81073 RVA: 0x002E2AA5 File Offset: 0x002E0CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06013CB2 RID: 81074 RVA: 0x002E2AAE File Offset: 0x002E0CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoRequest);
		}

		// Token: 0x06013CB3 RID: 81075 RVA: 0x002E2ABC File Offset: 0x002E0CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CB4 RID: 81076 RVA: 0x002E2AEC File Offset: 0x002E0CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CB5 RID: 81077 RVA: 0x002E2B2B File Offset: 0x002E0D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CB6 RID: 81078 RVA: 0x002E2B38 File Offset: 0x002E0D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CB7 RID: 81079 RVA: 0x002E2B41 File Offset: 0x002E0D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CB8 RID: 81080 RVA: 0x002E2B74 File Offset: 0x002E0D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013CB9 RID: 81081 RVA: 0x002E2BB2 File Offset: 0x002E0DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPlayerInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CBA RID: 81082 RVA: 0x002E2BE3 File Offset: 0x002E0DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CBB RID: 81083 RVA: 0x002E2BEC File Offset: 0x002E0DEC
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007998 RID: 31128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007999 RID: 31129
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400799A RID: 31130
		private int activityId_;
	}
}
