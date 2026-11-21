using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000953 RID: 2387
	[NetMessage(EMessageId.LordGymReadRequest)]
	public sealed class LordGymReadRequest : IMessage<LordGymReadRequest>, IMessage, IEquatable<LordGymReadRequest>, IDeepCloneable<LordGymReadRequest>, IBufferMessage
	{
		// Token: 0x0600D2B4 RID: 53940 RVA: 0x001F13E4 File Offset: 0x001EF5E4
		[NullableContext(1)]
		public static LordGymReadRequest Create()
		{
			return new LordGymReadRequest();
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600D2B5 RID: 53941 RVA: 0x001F13EB File Offset: 0x001EF5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x001F13EE File Offset: 0x001EF5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymReadRequest.Descriptor;
			}
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x001F13F5 File Offset: 0x001EF5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest()
		{
		}

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x001F13FD File Offset: 0x001EF5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest(LordGymReadRequest other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x001F1422 File Offset: 0x001EF622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest Clone()
		{
			return new LordGymReadRequest(this);
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x001F142A File Offset: 0x001EF62A
		// (set) Token: 0x0600D2BB RID: 53947 RVA: 0x001F1432 File Offset: 0x001EF632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x001F143B File Offset: 0x001EF63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymReadRequest);
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x001F1449 File Offset: 0x001EF649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymReadRequest other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x001F1478 File Offset: 0x001EF678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x001F14B7 File Offset: 0x001EF6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x001F14C4 File Offset: 0x001EF6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x001F14CD File Offset: 0x001EF6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x001F1500 File Offset: 0x001EF700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x001F153E File Offset: 0x001EF73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x001F156F File Offset: 0x001EF76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x001F1578 File Offset: 0x001EF778
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
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400590A RID: 22794
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400590B RID: 22795
		public const int LoadGymIdFieldNumber = 10;

		// Token: 0x0400590C RID: 22796
		private int loadGymId_;
	}
}
