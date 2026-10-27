using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E9 RID: 5097
	[NetMessage(EMessageId.TrackMoonRolePropChangeNotify)]
	public sealed class TrackMoonRolePropChangeNotify : IMessage<TrackMoonRolePropChangeNotify>, IMessage, IEquatable<TrackMoonRolePropChangeNotify>, IDeepCloneable<TrackMoonRolePropChangeNotify>, IBufferMessage
	{
		// Token: 0x0601B031 RID: 110641 RVA: 0x003E9649 File Offset: 0x003E7849
		[NullableContext(1)]
		public static TrackMoonRolePropChangeNotify Create()
		{
			return new TrackMoonRolePropChangeNotify();
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x0601B032 RID: 110642 RVA: 0x003E9650 File Offset: 0x003E7850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x0601B033 RID: 110643 RVA: 0x003E9653 File Offset: 0x003E7853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRolePropChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601B034 RID: 110644 RVA: 0x003E965A File Offset: 0x003E785A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify()
		{
		}

		// Token: 0x0601B035 RID: 110645 RVA: 0x003E966D File Offset: 0x003E786D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify(TrackMoonRolePropChangeNotify other) : this()
		{
			this.roleProps_ = other.roleProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B036 RID: 110646 RVA: 0x003E9697 File Offset: 0x003E7897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify Clone()
		{
			return new TrackMoonRolePropChangeNotify(this);
		}

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x0601B037 RID: 110647 RVA: 0x003E969F File Offset: 0x003E789F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustRoleInfo> RoleProps
		{
			get
			{
				return this.roleProps_;
			}
		}

		// Token: 0x0601B038 RID: 110648 RVA: 0x003E96A7 File Offset: 0x003E78A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRolePropChangeNotify);
		}

		// Token: 0x0601B039 RID: 110649 RVA: 0x003E96B5 File Offset: 0x003E78B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRolePropChangeNotify other)
		{
			return other != null && (other == this || (this.roleProps_.Equals(other.roleProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B03A RID: 110650 RVA: 0x003E96E8 File Offset: 0x003E78E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleProps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B03B RID: 110651 RVA: 0x003E971C File Offset: 0x003E791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B03C RID: 110652 RVA: 0x003E9729 File Offset: 0x003E7929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B03D RID: 110653 RVA: 0x003E9732 File Offset: 0x003E7932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleProps_.WriteTo(ref output, TrackMoonRolePropChangeNotify._repeated_roleProps_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B03E RID: 110654 RVA: 0x003E975C File Offset: 0x003E795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleProps_.CalculateSize(TrackMoonRolePropChangeNotify._repeated_roleProps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B03F RID: 110655 RVA: 0x003E9795 File Offset: 0x003E7995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonRolePropChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleProps_.Add(other.roleProps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B040 RID: 110656 RVA: 0x003E97C3 File Offset: 0x003E79C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B041 RID: 110657 RVA: 0x003E97CC File Offset: 0x003E79CC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleProps_.AddEntriesFrom(ref input, TrackMoonRolePropChangeNotify._repeated_roleProps_codec);
				}
			}
		}

		// Token: 0x04009C5E RID: 40030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C5F RID: 40031
		public const int RolePropsFieldNumber = 6;

		// Token: 0x04009C60 RID: 40032
		private static readonly FieldCodec<EntrustRoleInfo> _repeated_roleProps_codec = FieldCodec.ForMessage<EntrustRoleInfo>(50U, EntrustRoleInfo.Parser);

		// Token: 0x04009C61 RID: 40033
		private readonly RepeatedField<EntrustRoleInfo> roleProps_ = new RepeatedField<EntrustRoleInfo>();
	}
}
