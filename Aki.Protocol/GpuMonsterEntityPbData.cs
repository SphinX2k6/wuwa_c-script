using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F5 RID: 1781
	public sealed class GpuMonsterEntityPbData : IMessage<GpuMonsterEntityPbData>, IMessage, IEquatable<GpuMonsterEntityPbData>, IDeepCloneable<GpuMonsterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600A29C RID: 41628 RVA: 0x0018982E File Offset: 0x00187A2E
		[NullableContext(1)]
		public static GpuMonsterEntityPbData Create()
		{
			return new GpuMonsterEntityPbData();
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600A29D RID: 41629 RVA: 0x00189835 File Offset: 0x00187A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600A29E RID: 41630 RVA: 0x00189838 File Offset: 0x00187A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuMonsterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x0018983F File Offset: 0x00187A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData()
		{
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00189847 File Offset: 0x00187A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData(GpuMonsterEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00189860 File Offset: 0x00187A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData Clone()
		{
			return new GpuMonsterEntityPbData(this);
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x00189868 File Offset: 0x00187A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuMonsterEntityPbData);
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x00189876 File Offset: 0x00187A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuMonsterEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x00189894 File Offset: 0x00187A94
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

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x001898BA File Offset: 0x00187ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x001898C7 File Offset: 0x00187AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x001898D0 File Offset: 0x00187AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x001898E8 File Offset: 0x00187AE8
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

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x0018990E File Offset: 0x00187B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GpuMonsterEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x0018992B File Offset: 0x00187B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x00189934 File Offset: 0x00187B34
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

		// Token: 0x04004BB0 RID: 19376
		private UnknownFieldSet _unknownFields;
	}
}
