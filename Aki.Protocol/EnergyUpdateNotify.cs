using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000448 RID: 1096
	[NetMessage(EMessageId.EnergyUpdateNotify)]
	public sealed class EnergyUpdateNotify : IMessage<EnergyUpdateNotify>, IMessage, IEquatable<EnergyUpdateNotify>, IDeepCloneable<EnergyUpdateNotify>, IBufferMessage
	{
		// Token: 0x060068D3 RID: 26835 RVA: 0x000FBBCC File Offset: 0x000F9DCC
		[NullableContext(1)]
		public static EnergyUpdateNotify Create()
		{
			return new EnergyUpdateNotify();
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x000FBBD3 File Offset: 0x000F9DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060068D5 RID: 26837 RVA: 0x000FBBD6 File Offset: 0x000F9DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x000FBBDD File Offset: 0x000F9DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify()
		{
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x000FBBF0 File Offset: 0x000F9DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify(EnergyUpdateNotify other) : this()
		{
			this.updateInfoList_ = other.updateInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x000FBC1A File Offset: 0x000F9E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify Clone()
		{
			return new EnergyUpdateNotify(this);
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060068D9 RID: 26841 RVA: 0x000FBC22 File Offset: 0x000F9E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnergyInfo> UpdateInfoList
		{
			get
			{
				return this.updateInfoList_;
			}
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x000FBC2A File Offset: 0x000F9E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergyUpdateNotify);
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x000FBC38 File Offset: 0x000F9E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergyUpdateNotify other)
		{
			return other != null && (other == this || (this.updateInfoList_.Equals(other.updateInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x000FBC6C File Offset: 0x000F9E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x000FBCA0 File Offset: 0x000F9EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x000FBCAD File Offset: 0x000F9EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x000FBCB6 File Offset: 0x000F9EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateInfoList_.WriteTo(ref output, EnergyUpdateNotify._repeated_updateInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x000FBCE0 File Offset: 0x000F9EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateInfoList_.CalculateSize(EnergyUpdateNotify._repeated_updateInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x000FBD19 File Offset: 0x000F9F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnergyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateInfoList_.Add(other.updateInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x000FBD47 File Offset: 0x000F9F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x000FBD50 File Offset: 0x000F9F50
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.updateInfoList_.AddEntriesFrom(ref input, EnergyUpdateNotify._repeated_updateInfoList_codec);
				}
			}
		}

		// Token: 0x040039D2 RID: 14802
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D3 RID: 14803
		public const int UpdateInfoListFieldNumber = 11;

		// Token: 0x040039D4 RID: 14804
		private static readonly FieldCodec<EnergyInfo> _repeated_updateInfoList_codec = FieldCodec.ForMessage<EnergyInfo>(90U, EnergyInfo.Parser);

		// Token: 0x040039D5 RID: 14805
		private readonly RepeatedField<EnergyInfo> updateInfoList_ = new RepeatedField<EnergyInfo>();
	}
}
