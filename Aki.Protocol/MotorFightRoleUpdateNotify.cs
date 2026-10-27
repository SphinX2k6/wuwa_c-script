using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5E RID: 2654
	[NetMessage(EMessageId.MotorFightRoleUpdateNotify)]
	public sealed class MotorFightRoleUpdateNotify : IMessage<MotorFightRoleUpdateNotify>, IMessage, IEquatable<MotorFightRoleUpdateNotify>, IDeepCloneable<MotorFightRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E785 RID: 59269 RVA: 0x0021D2F8 File Offset: 0x0021B4F8
		[NullableContext(1)]
		public static MotorFightRoleUpdateNotify Create()
		{
			return new MotorFightRoleUpdateNotify();
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x0021D2FF File Offset: 0x0021B4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600E787 RID: 59271 RVA: 0x0021D302 File Offset: 0x0021B502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x0021D309 File Offset: 0x0021B509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify()
		{
		}

		// Token: 0x0600E789 RID: 59273 RVA: 0x0021D31C File Offset: 0x0021B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify(MotorFightRoleUpdateNotify other) : this()
		{
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E78A RID: 59274 RVA: 0x0021D346 File Offset: 0x0021B546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify Clone()
		{
			return new MotorFightRoleUpdateNotify(this);
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x0021D34E File Offset: 0x0021B54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x0600E78C RID: 59276 RVA: 0x0021D356 File Offset: 0x0021B556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoleUpdateNotify);
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x0021D364 File Offset: 0x0021B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x0021D398 File Offset: 0x0021B598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E78F RID: 59279 RVA: 0x0021D3CC File Offset: 0x0021B5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E790 RID: 59280 RVA: 0x0021D3D9 File Offset: 0x0021B5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x0021D3E2 File Offset: 0x0021B5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedRole_.WriteTo(ref output, MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x0021D40C File Offset: 0x0021B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedRole_.CalculateSize(MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x0021D445 File Offset: 0x0021B645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedRole_.Add(other.unlockedRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x0021D473 File Offset: 0x0021B673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x0021D47C File Offset: 0x0021B67C
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedRole_.AddEntriesFrom(ref input, MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
				}
			}
		}

		// Token: 0x04005E57 RID: 24151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E58 RID: 24152
		public const int UnlockedRoleFieldNumber = 15;

		// Token: 0x04005E59 RID: 24153
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04005E5A RID: 24154
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
