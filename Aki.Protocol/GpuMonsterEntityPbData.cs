using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000709 RID: 1801
	public sealed class GpuMonsterEntityPbData : IMessage<GpuMonsterEntityPbData>, IMessage, IEquatable<GpuMonsterEntityPbData>, IDeepCloneable<GpuMonsterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600A3F2 RID: 41970 RVA: 0x0018C262 File Offset: 0x0018A462
		[NullableContext(1)]
		public static GpuMonsterEntityPbData Create()
		{
			return new GpuMonsterEntityPbData();
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x0018C269 File Offset: 0x0018A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600A3F4 RID: 41972 RVA: 0x0018C26C File Offset: 0x0018A46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuMonsterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x0018C273 File Offset: 0x0018A473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData()
		{
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x0018C27B File Offset: 0x0018A47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData(GpuMonsterEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0018C294 File Offset: 0x0018A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterEntityPbData Clone()
		{
			return new GpuMonsterEntityPbData(this);
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x0018C29C File Offset: 0x0018A49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuMonsterEntityPbData);
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x0018C2AA File Offset: 0x0018A4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuMonsterEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x0018C2C8 File Offset: 0x0018A4C8
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

		// Token: 0x0600A3FB RID: 41979 RVA: 0x0018C2EE File Offset: 0x0018A4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x0018C2FB File Offset: 0x0018A4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x0018C304 File Offset: 0x0018A504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x0018C31C File Offset: 0x0018A51C
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

		// Token: 0x0600A3FF RID: 41983 RVA: 0x0018C342 File Offset: 0x0018A542
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

		// Token: 0x0600A400 RID: 41984 RVA: 0x0018C35F File Offset: 0x0018A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x0018C368 File Offset: 0x0018A568
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

		// Token: 0x04004BB7 RID: 19383
		private UnknownFieldSet _unknownFields;
	}
}
