using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000029 RID: 41
	[NetMessage(EMessageId.AbyssLikeRequest)]
	public sealed class AbyssLikeRequest : IMessage<AbyssLikeRequest>, IMessage, IEquatable<AbyssLikeRequest>, IDeepCloneable<AbyssLikeRequest>, IBufferMessage
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x00031779 File Offset: 0x0002F979
		[NullableContext(1)]
		public static AbyssLikeRequest Create()
		{
			return new AbyssLikeRequest();
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00031780 File Offset: 0x0002F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00031783 File Offset: 0x0002F983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeRequest.Descriptor;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0003178A File Offset: 0x0002F98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest()
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00031792 File Offset: 0x0002F992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest(AbyssLikeRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000317B7 File Offset: 0x0002F9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest Clone()
		{
			return new AbyssLikeRequest(this);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000317BF File Offset: 0x0002F9BF
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x000317C7 File Offset: 0x0002F9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000317D0 File Offset: 0x0002F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeRequest);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000317DE File Offset: 0x0002F9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0003180C File Offset: 0x0002FA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0003184B File Offset: 0x0002FA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00031858 File Offset: 0x0002FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00031861 File Offset: 0x0002FA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00031894 File Offset: 0x0002FA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000318D2 File Offset: 0x0002FAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00031903 File Offset: 0x0002FB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0003190C File Offset: 0x0002FB0C
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
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FA1 RID: 8097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA2 RID: 8098
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04001FA3 RID: 8099
		private int playerId_;
	}
}
