using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145C RID: 5212
	[NetMessage(EMessageId.TrackMoonRolePropChangeNotify)]
	public sealed class TrackMoonRolePropChangeNotify : IMessage<TrackMoonRolePropChangeNotify>, IMessage, IEquatable<TrackMoonRolePropChangeNotify>, IDeepCloneable<TrackMoonRolePropChangeNotify>, IBufferMessage
	{
		// Token: 0x0601BABC RID: 113340 RVA: 0x00404915 File Offset: 0x00402B15
		[NullableContext(1)]
		public static TrackMoonRolePropChangeNotify Create()
		{
			return new TrackMoonRolePropChangeNotify();
		}

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x0601BABD RID: 113341 RVA: 0x0040491C File Offset: 0x00402B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x0601BABE RID: 113342 RVA: 0x0040491F File Offset: 0x00402B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRolePropChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601BABF RID: 113343 RVA: 0x00404926 File Offset: 0x00402B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify()
		{
		}

		// Token: 0x0601BAC0 RID: 113344 RVA: 0x00404939 File Offset: 0x00402B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify(TrackMoonRolePropChangeNotify other) : this()
		{
			this.roleProps_ = other.roleProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAC1 RID: 113345 RVA: 0x00404963 File Offset: 0x00402B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRolePropChangeNotify Clone()
		{
			return new TrackMoonRolePropChangeNotify(this);
		}

		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x0601BAC2 RID: 113346 RVA: 0x0040496B File Offset: 0x00402B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustRoleInfo> RoleProps
		{
			get
			{
				return this.roleProps_;
			}
		}

		// Token: 0x0601BAC3 RID: 113347 RVA: 0x00404973 File Offset: 0x00402B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRolePropChangeNotify);
		}

		// Token: 0x0601BAC4 RID: 113348 RVA: 0x00404981 File Offset: 0x00402B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRolePropChangeNotify other)
		{
			return other != null && (other == this || (this.roleProps_.Equals(other.roleProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAC5 RID: 113349 RVA: 0x004049B4 File Offset: 0x00402BB4
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

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x004049E8 File Offset: 0x00402BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAC7 RID: 113351 RVA: 0x004049F5 File Offset: 0x00402BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAC8 RID: 113352 RVA: 0x004049FE File Offset: 0x00402BFE
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

		// Token: 0x0601BAC9 RID: 113353 RVA: 0x00404A28 File Offset: 0x00402C28
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

		// Token: 0x0601BACA RID: 113354 RVA: 0x00404A61 File Offset: 0x00402C61
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

		// Token: 0x0601BACB RID: 113355 RVA: 0x00404A8F File Offset: 0x00402C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BACC RID: 113356 RVA: 0x00404A98 File Offset: 0x00402C98
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleProps_.AddEntriesFrom(ref input, TrackMoonRolePropChangeNotify._repeated_roleProps_codec);
				}
			}
		}

		// Token: 0x0400A0A5 RID: 41125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0A6 RID: 41126
		public const int RolePropsFieldNumber = 7;

		// Token: 0x0400A0A7 RID: 41127
		private static readonly FieldCodec<EntrustRoleInfo> _repeated_roleProps_codec = FieldCodec.ForMessage<EntrustRoleInfo>(58U, EntrustRoleInfo.Parser);

		// Token: 0x0400A0A8 RID: 41128
		private readonly RepeatedField<EntrustRoleInfo> roleProps_ = new RepeatedField<EntrustRoleInfo>();
	}
}
