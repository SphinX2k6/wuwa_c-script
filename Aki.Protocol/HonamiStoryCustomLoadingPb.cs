using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000770 RID: 1904
	public sealed class HonamiStoryCustomLoadingPb : IMessage<HonamiStoryCustomLoadingPb>, IMessage, IEquatable<HonamiStoryCustomLoadingPb>, IDeepCloneable<HonamiStoryCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0600AC29 RID: 44073 RVA: 0x0019E020 File Offset: 0x0019C220
		[NullableContext(1)]
		public static HonamiStoryCustomLoadingPb Create()
		{
			return new HonamiStoryCustomLoadingPb();
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x0019E027 File Offset: 0x0019C227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600AC2B RID: 44075 RVA: 0x0019E02A File Offset: 0x0019C22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x0019E031 File Offset: 0x0019C231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb()
		{
		}

		// Token: 0x0600AC2D RID: 44077 RVA: 0x0019E039 File Offset: 0x0019C239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb(HonamiStoryCustomLoadingPb other) : this()
		{
			this.loadingId_ = other.loadingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC2E RID: 44078 RVA: 0x0019E05E File Offset: 0x0019C25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb Clone()
		{
			return new HonamiStoryCustomLoadingPb(this);
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600AC2F RID: 44079 RVA: 0x0019E066 File Offset: 0x0019C266
		// (set) Token: 0x0600AC30 RID: 44080 RVA: 0x0019E06E File Offset: 0x0019C26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadingId
		{
			get
			{
				return this.loadingId_;
			}
			set
			{
				this.loadingId_ = value;
			}
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x0019E077 File Offset: 0x0019C277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryCustomLoadingPb);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x0019E085 File Offset: 0x0019C285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryCustomLoadingPb other)
		{
			return other != null && (other == this || (this.LoadingId == other.LoadingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x0019E0B4 File Offset: 0x0019C2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadingId != 0)
			{
				num ^= this.LoadingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0019E0F3 File Offset: 0x0019C2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x0019E100 File Offset: 0x0019C300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x0019E109 File Offset: 0x0019C309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadingId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoadingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x0019E13C File Offset: 0x0019C33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x0019E17A File Offset: 0x0019C37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryCustomLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadingId != 0)
			{
				this.LoadingId = other.LoadingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x0019E1AB File Offset: 0x0019C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x0019E1B4 File Offset: 0x0019C3B4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E0A RID: 19978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0B RID: 19979
		public const int LoadingIdFieldNumber = 1;

		// Token: 0x04004E0C RID: 19980
		private int loadingId_;
	}
}
