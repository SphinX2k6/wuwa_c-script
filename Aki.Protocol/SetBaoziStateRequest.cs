using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001203 RID: 4611
	[NetMessage(EMessageId.SetBaoziStateRequest)]
	public sealed class SetBaoziStateRequest : IMessage<SetBaoziStateRequest>, IMessage, IEquatable<SetBaoziStateRequest>, IDeepCloneable<SetBaoziStateRequest>, IBufferMessage
	{
		// Token: 0x06018A3B RID: 100923 RVA: 0x003980F5 File Offset: 0x003962F5
		[NullableContext(1)]
		public static SetBaoziStateRequest Create()
		{
			return new SetBaoziStateRequest();
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x06018A3C RID: 100924 RVA: 0x003980FC File Offset: 0x003962FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x06018A3D RID: 100925 RVA: 0x003980FF File Offset: 0x003962FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBaoziStateRequest.Descriptor;
			}
		}

		// Token: 0x06018A3E RID: 100926 RVA: 0x00398106 File Offset: 0x00396306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest()
		{
		}

		// Token: 0x06018A3F RID: 100927 RVA: 0x0039810E File Offset: 0x0039630E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest(SetBaoziStateRequest other) : this()
		{
			this.fanEntityId_ = other.fanEntityId_;
			this.baoziEntityId_ = other.baoziEntityId_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A40 RID: 100928 RVA: 0x0039814B File Offset: 0x0039634B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest Clone()
		{
			return new SetBaoziStateRequest(this);
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x06018A41 RID: 100929 RVA: 0x00398153 File Offset: 0x00396353
		// (set) Token: 0x06018A42 RID: 100930 RVA: 0x0039815B File Offset: 0x0039635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FanEntityId
		{
			get
			{
				return this.fanEntityId_;
			}
			set
			{
				this.fanEntityId_ = value;
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x06018A43 RID: 100931 RVA: 0x00398164 File Offset: 0x00396364
		// (set) Token: 0x06018A44 RID: 100932 RVA: 0x0039816C File Offset: 0x0039636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BaoziEntityId
		{
			get
			{
				return this.baoziEntityId_;
			}
			set
			{
				this.baoziEntityId_ = value;
			}
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x06018A45 RID: 100933 RVA: 0x00398175 File Offset: 0x00396375
		// (set) Token: 0x06018A46 RID: 100934 RVA: 0x0039817D File Offset: 0x0039637D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x06018A47 RID: 100935 RVA: 0x00398186 File Offset: 0x00396386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBaoziStateRequest);
		}

		// Token: 0x06018A48 RID: 100936 RVA: 0x00398194 File Offset: 0x00396394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBaoziStateRequest other)
		{
			return other != null && (other == this || (this.FanEntityId == other.FanEntityId && this.BaoziEntityId == other.BaoziEntityId && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A49 RID: 100937 RVA: 0x003981F0 File Offset: 0x003963F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FanEntityId != 0L)
			{
				num ^= this.FanEntityId.GetHashCode();
			}
			if (this.BaoziEntityId != 0L)
			{
				num ^= this.BaoziEntityId.GetHashCode();
			}
			if (this.IsActive != 0)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A4A RID: 100938 RVA: 0x00398261 File Offset: 0x00396461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A4B RID: 100939 RVA: 0x0039826E File Offset: 0x0039646E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A4C RID: 100940 RVA: 0x00398278 File Offset: 0x00396478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FanEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.FanEntityId);
			}
			if (this.BaoziEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.BaoziEntityId);
			}
			if (this.IsActive != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A4D RID: 100941 RVA: 0x003982F0 File Offset: 0x003964F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FanEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FanEntityId);
			}
			if (this.BaoziEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BaoziEntityId);
			}
			if (this.IsActive != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A4E RID: 100942 RVA: 0x00398360 File Offset: 0x00396560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBaoziStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FanEntityId != 0L)
			{
				this.FanEntityId = other.FanEntityId;
			}
			if (other.BaoziEntityId != 0L)
			{
				this.BaoziEntityId = other.BaoziEntityId;
			}
			if (other.IsActive != 0)
			{
				this.IsActive = other.IsActive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A4F RID: 100943 RVA: 0x003983C4 File Offset: 0x003965C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A50 RID: 100944 RVA: 0x003983D0 File Offset: 0x003965D0
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
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsActive = input.ReadInt32();
						}
					}
					else
					{
						this.BaoziEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.FanEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009276 RID: 37494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009277 RID: 37495
		public const int FanEntityIdFieldNumber = 3;

		// Token: 0x04009278 RID: 37496
		private long fanEntityId_;

		// Token: 0x04009279 RID: 37497
		public const int BaoziEntityIdFieldNumber = 10;

		// Token: 0x0400927A RID: 37498
		private long baoziEntityId_;

		// Token: 0x0400927B RID: 37499
		public const int IsActiveFieldNumber = 14;

		// Token: 0x0400927C RID: 37500
		private int isActive_;
	}
}
