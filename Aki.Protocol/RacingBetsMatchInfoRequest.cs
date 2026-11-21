using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E58 RID: 3672
	[NetMessage(EMessageId.RacingBetsMatchInfoRequest)]
	public sealed class RacingBetsMatchInfoRequest : IMessage<RacingBetsMatchInfoRequest>, IMessage, IEquatable<RacingBetsMatchInfoRequest>, IDeepCloneable<RacingBetsMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013C1E RID: 80926 RVA: 0x002E1382 File Offset: 0x002DF582
		[NullableContext(1)]
		public static RacingBetsMatchInfoRequest Create()
		{
			return new RacingBetsMatchInfoRequest();
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06013C1F RID: 80927 RVA: 0x002E1389 File Offset: 0x002DF589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06013C20 RID: 80928 RVA: 0x002E138C File Offset: 0x002DF58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013C21 RID: 80929 RVA: 0x002E1393 File Offset: 0x002DF593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest()
		{
		}

		// Token: 0x06013C22 RID: 80930 RVA: 0x002E139B File Offset: 0x002DF59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest(RacingBetsMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C23 RID: 80931 RVA: 0x002E13C0 File Offset: 0x002DF5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest Clone()
		{
			return new RacingBetsMatchInfoRequest(this);
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x06013C24 RID: 80932 RVA: 0x002E13C8 File Offset: 0x002DF5C8
		// (set) Token: 0x06013C25 RID: 80933 RVA: 0x002E13D0 File Offset: 0x002DF5D0
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

		// Token: 0x06013C26 RID: 80934 RVA: 0x002E13D9 File Offset: 0x002DF5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchInfoRequest);
		}

		// Token: 0x06013C27 RID: 80935 RVA: 0x002E13E7 File Offset: 0x002DF5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C28 RID: 80936 RVA: 0x002E1418 File Offset: 0x002DF618
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

		// Token: 0x06013C29 RID: 80937 RVA: 0x002E1457 File Offset: 0x002DF657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C2A RID: 80938 RVA: 0x002E1464 File Offset: 0x002DF664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C2B RID: 80939 RVA: 0x002E146D File Offset: 0x002DF66D
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

		// Token: 0x06013C2C RID: 80940 RVA: 0x002E14A0 File Offset: 0x002DF6A0
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

		// Token: 0x06013C2D RID: 80941 RVA: 0x002E14DE File Offset: 0x002DF6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchInfoRequest other)
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

		// Token: 0x06013C2E RID: 80942 RVA: 0x002E150F File Offset: 0x002DF70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C2F RID: 80943 RVA: 0x002E1518 File Offset: 0x002DF718
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

		// Token: 0x04007960 RID: 31072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007961 RID: 31073
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04007962 RID: 31074
		private int activityId_;
	}
}
