using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000750 RID: 1872
	[NetMessage(EMessageId.HonamiStoryAreaSecretRewardRequest)]
	public sealed class HonamiStoryAreaSecretRewardRequest : IMessage<HonamiStoryAreaSecretRewardRequest>, IMessage, IEquatable<HonamiStoryAreaSecretRewardRequest>, IDeepCloneable<HonamiStoryAreaSecretRewardRequest>, IBufferMessage
	{
		// Token: 0x0600A9E3 RID: 43491 RVA: 0x00199755 File Offset: 0x00197955
		[NullableContext(1)]
		public static HonamiStoryAreaSecretRewardRequest Create()
		{
			return new HonamiStoryAreaSecretRewardRequest();
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x0019975C File Offset: 0x0019795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x0019975F File Offset: 0x0019795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaSecretRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x00199766 File Offset: 0x00197966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest()
		{
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x0019976E File Offset: 0x0019796E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest(HonamiStoryAreaSecretRewardRequest other) : this()
		{
			this.areaSecretId_ = other.areaSecretId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x00199793 File Offset: 0x00197993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest Clone()
		{
			return new HonamiStoryAreaSecretRewardRequest(this);
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x0019979B File Offset: 0x0019799B
		// (set) Token: 0x0600A9EA RID: 43498 RVA: 0x001997A3 File Offset: 0x001979A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaSecretId
		{
			get
			{
				return this.areaSecretId_;
			}
			set
			{
				this.areaSecretId_ = value;
			}
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x001997AC File Offset: 0x001979AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaSecretRewardRequest);
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x001997BA File Offset: 0x001979BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaSecretRewardRequest other)
		{
			return other != null && (other == this || (this.AreaSecretId == other.AreaSecretId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x001997E8 File Offset: 0x001979E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaSecretId != 0)
			{
				num ^= this.AreaSecretId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x00199827 File Offset: 0x00197A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x00199834 File Offset: 0x00197A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x0019983D File Offset: 0x00197A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaSecretId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AreaSecretId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x00199870 File Offset: 0x00197A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaSecretId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaSecretId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x001998AE File Offset: 0x00197AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaSecretRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaSecretId != 0)
			{
				this.AreaSecretId = other.AreaSecretId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x001998DF File Offset: 0x00197ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x001998E8 File Offset: 0x00197AE8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaSecretId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DC2 RID: 19906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DC3 RID: 19907
		public const int AreaSecretIdFieldNumber = 4;

		// Token: 0x04004DC4 RID: 19908
		private int areaSecretId_;
	}
}
