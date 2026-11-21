using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3D RID: 2877
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateRequest)]
	public sealed class NewTowerSeasonTaskDataUpdateRequest : IMessage<NewTowerSeasonTaskDataUpdateRequest>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateRequest>, IDeepCloneable<NewTowerSeasonTaskDataUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600F9DF RID: 63967 RVA: 0x002472A6 File Offset: 0x002454A6
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateRequest Create()
		{
			return new NewTowerSeasonTaskDataUpdateRequest();
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600F9E0 RID: 63968 RVA: 0x002472AD File Offset: 0x002454AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600F9E1 RID: 63969 RVA: 0x002472B0 File Offset: 0x002454B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600F9E2 RID: 63970 RVA: 0x002472B7 File Offset: 0x002454B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest()
		{
		}

		// Token: 0x0600F9E3 RID: 63971 RVA: 0x002472BF File Offset: 0x002454BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest(NewTowerSeasonTaskDataUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9E4 RID: 63972 RVA: 0x002472D8 File Offset: 0x002454D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest Clone()
		{
			return new NewTowerSeasonTaskDataUpdateRequest(this);
		}

		// Token: 0x0600F9E5 RID: 63973 RVA: 0x002472E0 File Offset: 0x002454E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateRequest);
		}

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x002472EE File Offset: 0x002454EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x0024730C File Offset: 0x0024550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F9E8 RID: 63976 RVA: 0x00247332 File Offset: 0x00245532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9E9 RID: 63977 RVA: 0x0024733F File Offset: 0x0024553F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9EA RID: 63978 RVA: 0x00247348 File Offset: 0x00245548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9EB RID: 63979 RVA: 0x00247360 File Offset: 0x00245560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F9EC RID: 63980 RVA: 0x00247386 File Offset: 0x00245586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonTaskDataUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F9ED RID: 63981 RVA: 0x002473A3 File Offset: 0x002455A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9EE RID: 63982 RVA: 0x002473AC File Offset: 0x002455AC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006470 RID: 25712
		private UnknownFieldSet _unknownFields;
	}
}
