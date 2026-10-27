using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D81 RID: 3457
	[NetMessage(EMessageId.PlayerBasicInfoGetRequest)]
	public sealed class PlayerBasicInfoGetRequest : IMessage<PlayerBasicInfoGetRequest>, IMessage, IEquatable<PlayerBasicInfoGetRequest>, IDeepCloneable<PlayerBasicInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012A2E RID: 76334 RVA: 0x002B7EBD File Offset: 0x002B60BD
		[NullableContext(1)]
		public static PlayerBasicInfoGetRequest Create()
		{
			return new PlayerBasicInfoGetRequest();
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x06012A2F RID: 76335 RVA: 0x002B7EC4 File Offset: 0x002B60C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x06012A30 RID: 76336 RVA: 0x002B7EC7 File Offset: 0x002B60C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBasicInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x002B7ECE File Offset: 0x002B60CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest()
		{
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x002B7ED6 File Offset: 0x002B60D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest(PlayerBasicInfoGetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A33 RID: 76339 RVA: 0x002B7EFB File Offset: 0x002B60FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest Clone()
		{
			return new PlayerBasicInfoGetRequest(this);
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x06012A34 RID: 76340 RVA: 0x002B7F03 File Offset: 0x002B6103
		// (set) Token: 0x06012A35 RID: 76341 RVA: 0x002B7F0B File Offset: 0x002B610B
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

		// Token: 0x06012A36 RID: 76342 RVA: 0x002B7F14 File Offset: 0x002B6114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBasicInfoGetRequest);
		}

		// Token: 0x06012A37 RID: 76343 RVA: 0x002B7F22 File Offset: 0x002B6122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBasicInfoGetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A38 RID: 76344 RVA: 0x002B7F50 File Offset: 0x002B6150
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

		// Token: 0x06012A39 RID: 76345 RVA: 0x002B7F8F File Offset: 0x002B618F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A3A RID: 76346 RVA: 0x002B7F9C File Offset: 0x002B619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A3B RID: 76347 RVA: 0x002B7FA5 File Offset: 0x002B61A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A3C RID: 76348 RVA: 0x002B7FD8 File Offset: 0x002B61D8
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

		// Token: 0x06012A3D RID: 76349 RVA: 0x002B8016 File Offset: 0x002B6216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBasicInfoGetRequest other)
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

		// Token: 0x06012A3E RID: 76350 RVA: 0x002B8047 File Offset: 0x002B6247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x002B8050 File Offset: 0x002B6250
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040073A0 RID: 29600
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073A1 RID: 29601
		public const int IdFieldNumber = 2;

		// Token: 0x040073A2 RID: 29602
		private int id_;
	}
}
