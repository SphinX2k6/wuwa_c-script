using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AC RID: 4268
	[NetMessage(EMessageId.RoleShowListUpdateRequest)]
	public sealed class RoleShowListUpdateRequest : IMessage<RoleShowListUpdateRequest>, IMessage, IEquatable<RoleShowListUpdateRequest>, IDeepCloneable<RoleShowListUpdateRequest>, IBufferMessage
	{
		// Token: 0x06016CA3 RID: 93347 RVA: 0x0034FB41 File Offset: 0x0034DD41
		[NullableContext(1)]
		public static RoleShowListUpdateRequest Create()
		{
			return new RoleShowListUpdateRequest();
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x06016CA4 RID: 93348 RVA: 0x0034FB48 File Offset: 0x0034DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x06016CA5 RID: 93349 RVA: 0x0034FB4B File Offset: 0x0034DD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06016CA6 RID: 93350 RVA: 0x0034FB52 File Offset: 0x0034DD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest()
		{
		}

		// Token: 0x06016CA7 RID: 93351 RVA: 0x0034FB65 File Offset: 0x0034DD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest(RoleShowListUpdateRequest other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CA8 RID: 93352 RVA: 0x0034FB8F File Offset: 0x0034DD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest Clone()
		{
			return new RoleShowListUpdateRequest(this);
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x06016CA9 RID: 93353 RVA: 0x0034FB97 File Offset: 0x0034DD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06016CAA RID: 93354 RVA: 0x0034FB9F File Offset: 0x0034DD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateRequest);
		}

		// Token: 0x06016CAB RID: 93355 RVA: 0x0034FBAD File Offset: 0x0034DDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateRequest other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CAC RID: 93356 RVA: 0x0034FBE0 File Offset: 0x0034DDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016CAD RID: 93357 RVA: 0x0034FC14 File Offset: 0x0034DE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CAE RID: 93358 RVA: 0x0034FC21 File Offset: 0x0034DE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CAF RID: 93359 RVA: 0x0034FC2A File Offset: 0x0034DE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, RoleShowListUpdateRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x0034FC54 File Offset: 0x0034DE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(RoleShowListUpdateRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016CB1 RID: 93361 RVA: 0x0034FC8D File Offset: 0x0034DE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowListUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016CB2 RID: 93362 RVA: 0x0034FCBB File Offset: 0x0034DEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CB3 RID: 93363 RVA: 0x0034FCC4 File Offset: 0x0034DEC4
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, RoleShowListUpdateRequest._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x0400880C RID: 34828
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400880D RID: 34829
		public const int RoleListFieldNumber = 3;

		// Token: 0x0400880E RID: 34830
		private static readonly FieldCodec<int> _repeated_roleList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400880F RID: 34831
		private readonly RepeatedField<int> roleList_ = new RepeatedField<int>();
	}
}
