using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127D RID: 4733
	[NetMessage(EMessageId.SpringSignDrawRewardRequest)]
	public sealed class SpringSignDrawRewardRequest : IMessage<SpringSignDrawRewardRequest>, IMessage, IEquatable<SpringSignDrawRewardRequest>, IDeepCloneable<SpringSignDrawRewardRequest>, IBufferMessage
	{
		// Token: 0x06019362 RID: 103266 RVA: 0x003AB12A File Offset: 0x003A932A
		[NullableContext(1)]
		public static SpringSignDrawRewardRequest Create()
		{
			return new SpringSignDrawRewardRequest();
		}

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x06019363 RID: 103267 RVA: 0x003AB131 File Offset: 0x003A9331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x06019364 RID: 103268 RVA: 0x003AB134 File Offset: 0x003A9334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019365 RID: 103269 RVA: 0x003AB13B File Offset: 0x003A933B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest()
		{
		}

		// Token: 0x06019366 RID: 103270 RVA: 0x003AB143 File Offset: 0x003A9343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest(SpringSignDrawRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019367 RID: 103271 RVA: 0x003AB168 File Offset: 0x003A9368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest Clone()
		{
			return new SpringSignDrawRewardRequest(this);
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x06019368 RID: 103272 RVA: 0x003AB170 File Offset: 0x003A9370
		// (set) Token: 0x06019369 RID: 103273 RVA: 0x003AB178 File Offset: 0x003A9378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601936A RID: 103274 RVA: 0x003AB181 File Offset: 0x003A9381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRewardRequest);
		}

		// Token: 0x0601936B RID: 103275 RVA: 0x003AB18F File Offset: 0x003A938F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601936C RID: 103276 RVA: 0x003AB1C0 File Offset: 0x003A93C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601936D RID: 103277 RVA: 0x003AB1FF File Offset: 0x003A93FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601936E RID: 103278 RVA: 0x003AB20C File Offset: 0x003A940C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601936F RID: 103279 RVA: 0x003AB215 File Offset: 0x003A9415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019370 RID: 103280 RVA: 0x003AB248 File Offset: 0x003A9448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019371 RID: 103281 RVA: 0x003AB286 File Offset: 0x003A9486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019372 RID: 103282 RVA: 0x003AB2B7 File Offset: 0x003A94B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019373 RID: 103283 RVA: 0x003AB2C0 File Offset: 0x003A94C0
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009462 RID: 37986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009463 RID: 37987
		public const int IdFieldNumber = 3;

		// Token: 0x04009464 RID: 37988
		private int id_;
	}
}
