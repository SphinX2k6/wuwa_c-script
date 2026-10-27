using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000426 RID: 1062
	[NetMessage(EMessageId.EdgeRunnerPreUnlockAvailableNotify)]
	public sealed class EdgeRunnerPreUnlockAvailableNotify : IMessage<EdgeRunnerPreUnlockAvailableNotify>, IMessage, IEquatable<EdgeRunnerPreUnlockAvailableNotify>, IDeepCloneable<EdgeRunnerPreUnlockAvailableNotify>, IBufferMessage
	{
		// Token: 0x06006611 RID: 26129 RVA: 0x000F5A3B File Offset: 0x000F3C3B
		[NullableContext(1)]
		public static EdgeRunnerPreUnlockAvailableNotify Create()
		{
			return new EdgeRunnerPreUnlockAvailableNotify();
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x000F5A42 File Offset: 0x000F3C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x000F5A45 File Offset: 0x000F3C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerPreUnlockAvailableNotify.Descriptor;
			}
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x000F5A4C File Offset: 0x000F3C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify()
		{
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x000F5A5F File Offset: 0x000F3C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify(EdgeRunnerPreUnlockAvailableNotify other) : this()
		{
			this.preUnlockIds_ = other.preUnlockIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x000F5A89 File Offset: 0x000F3C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify Clone()
		{
			return new EdgeRunnerPreUnlockAvailableNotify(this);
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x000F5A91 File Offset: 0x000F3C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreUnlockIds
		{
			get
			{
				return this.preUnlockIds_;
			}
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x000F5A99 File Offset: 0x000F3C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerPreUnlockAvailableNotify);
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x000F5AA7 File Offset: 0x000F3CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerPreUnlockAvailableNotify other)
		{
			return other != null && (other == this || (this.preUnlockIds_.Equals(other.preUnlockIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x000F5ADC File Offset: 0x000F3CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.preUnlockIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x000F5B10 File Offset: 0x000F3D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x000F5B1D File Offset: 0x000F3D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x000F5B26 File Offset: 0x000F3D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preUnlockIds_.WriteTo(ref output, EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x000F5B50 File Offset: 0x000F3D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.preUnlockIds_.CalculateSize(EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x000F5B89 File Offset: 0x000F3D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerPreUnlockAvailableNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.preUnlockIds_.Add(other.preUnlockIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x000F5BB7 File Offset: 0x000F3DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x000F5BC0 File Offset: 0x000F3DC0
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.preUnlockIds_.AddEntriesFrom(ref input, EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
				}
			}
		}

		// Token: 0x0400390F RID: 14607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003910 RID: 14608
		public const int PreUnlockIdsFieldNumber = 7;

		// Token: 0x04003911 RID: 14609
		private static readonly FieldCodec<int> _repeated_preUnlockIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04003912 RID: 14610
		private readonly RepeatedField<int> preUnlockIds_ = new RepeatedField<int>();
	}
}
